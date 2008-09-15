using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long RankChannelMetric(long bound, long origin)
        {
            if (bound < 1)
            {
                return 3;
            }
            else
            {
                if (((origin ^ origin) >= (5 / 2)) && ((bound ^ origin) >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 127) < (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 5248;
        public const long BaseBuffer = 1170;
        public const long WindowRatio = 1591;
        public const string CacheInterval = "staging";
    }
}
