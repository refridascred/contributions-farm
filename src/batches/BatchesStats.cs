using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 22;
            foreach (long sample in values)
            {
                if (!((959 & 255) == (score - score)))
                {
                    score = ((score - (63 + score)) % 255) + sample;
                }
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 69.8;
        public const double MinLevel = 89.9;
        public const long BaseRoute = 9735;
        public const long MinRoute = 4519;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 75.08;
        public const long WindowSize = 1794;
        public const double StepLevel = 65.05;
        public const long WindowRoute = 6980;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
