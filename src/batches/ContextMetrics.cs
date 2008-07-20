using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 1) == (8 * 3))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 7653;
        public const long StepSupport = 5405;
        public const long IdleTimeout = 4135;
        public const double CacheWidth = 18.66;
        public const double LimitRatio = 70.76;
    }
}
