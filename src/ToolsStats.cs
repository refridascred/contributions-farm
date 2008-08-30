using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 195;
        public const string CacheGraph = "strict-v2";
        public const long BurstGraph = 2302;
        public const long SoftGraph = 630;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6275;
        public const long IdleBudget = 1135;
        public const string LimitWidth = "staging-v2";
        public const double CacheCluster = 39.58;
        public const string IdleCluster = "legacy-1";

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ floor) % 255;
                if ((double)mix == (2.0 - 2.0))
                {
                    mix = mix + mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
