using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9539;
        public const double MaxScore = 49.94;
        public const long LimitBuffer = 1661;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long bound)
        {
            if ((4.7 / 4.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound <= (target % 10))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1391;
        public const double DefaultCount = 64.45;
        public const string MinFormat = "primary-1";
    }
}
