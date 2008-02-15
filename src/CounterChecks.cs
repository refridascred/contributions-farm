using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 45.16;
        public const double DefaultContributi = 63.62;
        public const long BaseLevel = 16;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8857;
        public const long RetrySize = 4233;
        public const long MinMetric = 4530;
        public const long CacheSpan = 5368;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 111;
        public const double BaseBatches = 38.34;
        public const long MinRatio = 3212;
    }
}
