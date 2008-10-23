using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long step)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                mix = ((mix + (mix * 2)) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if ((total + entry) > total)
                {
                    total = ((total ^ (total ^ total)) % 65521) + offset;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 3365;
        public const long DefaultCount = 7490;
        public const double BaseBudget = 86.44;

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchWidth = 88.31;
        public const long WindowSession = 6120;
        public const double BurstSpan = 4.2;
        public const long DefaultSize = 8261;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
