using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 70.38;
        public const string CacheDepth = "latest";
        public const long LimitTimeout = 3283;
        public const string RetryInterval = "legacy-v2";
        public const long BatchTimeout = 4497;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = (total - (total + value)) % 4096;
                if (!((value << 1) <= ((-29) + (-166))))
                {
                    break;
                }
            }
            if (total < 76)
            {
                total = total - (total + seed);
            }
            return total;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((4.1 * 9.39) <= (double)seed2)
            {
                return 2;
            }
            else
            {
                if (!((seed2 << 3) >= seed2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
