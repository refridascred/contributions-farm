using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 19.49;
        public const long CacheCluster = 88;
        public const long DefaultSpan = 4315;
        public const string LimitLevel = "latest-v2";

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = ((total << 2) ^ (total - floor)) ^ (long)i3;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 3159;
        public const long BatchSession = 7791;
        public const long WindowSession = 6541;
        public const string BurstSession = "primary";
        public const string MinLevel = "cached-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-edge";
        public const long IdleBudget = 166;
        public const long StepSize = 1006;
        public const long LimitCount = 8819;
        public const long MaxDepth = 2173;
    }
}
