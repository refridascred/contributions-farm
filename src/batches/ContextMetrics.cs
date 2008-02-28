using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long ScoreEditorMetrics(long[] levels)
        {
            long carry = 837;
            foreach (long reading in levels)
            {
                if (3.72 > (double)reading)
                {
                    carry = (carry + (carry % 10)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed + sample) == (seed & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Ready,
            Closed,
            Retry,
            New,
        }
    }
}
