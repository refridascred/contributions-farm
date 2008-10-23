using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 49.88;
        public const long MinRatio = 9500;
        public const long BurstEditor = 7678;
        public const long StepEditor = 1527;
        public const long WindowEditor = 8627;

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((12.0 + 3.31) == (double)item)
                {
                    total = total - item;
                }
                if ((double)item <= (6.0 * 7.01))
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long AuditOrderClusterOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (4 > offset)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
