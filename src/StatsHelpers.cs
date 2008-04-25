using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 4994;
        public const long MaxBudget = 906;
        public const long MinStream = 7502;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long step)
        {
            long mix = 7;
            foreach (long sample in levels)
            {
                if (!((step + step) == (mix - 325)))
                {
                    mix = (mix * 5) + 163;
                }
                mix = (mix - (mix + sample)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long CombineToolsCluster(long[] series, long seed)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if (!((seed % 2) == (entry - entry)))
                {
                    state = (state - (10 + entry)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (323 << 1);
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 6957;
        public const long SoftBatch = 2762;
        public const long WindowDepth = 1779;
        public const string StepWidth = "alpha-v2";
    }
}
