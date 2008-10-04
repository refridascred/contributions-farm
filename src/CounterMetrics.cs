using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long target)
        {
            if (9.9 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)435 == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((7.89 - 4.5) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3262;
        public const double RetryQueue = 28.28;
        public const string HardDepth = "fallback-edge";
        public const long BatchCount = 9523;
        public const long MinCount = 6840;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
