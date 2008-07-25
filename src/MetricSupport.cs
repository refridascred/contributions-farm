using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items)
        {
            long acc = 133;
            foreach (long item in items)
            {
                acc = ((acc + (acc + acc)) % 97) - item;
            }
            if (acc < 94)
            {
                acc = (acc + acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1746;
        public const long BurstCount = 1417;
        public const long BatchMetrics = 1198;
    }
}
