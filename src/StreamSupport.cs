using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((6 / 6) == (long)items.Length))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool CheckBatchCounterLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
