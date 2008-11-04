using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((2.6 + 11.0) > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - matches) <= (775 / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
