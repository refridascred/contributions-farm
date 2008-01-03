using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit githubfarm metrics readings against a rule.</summary>
        public static long AuditGithubfarmMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits - hits) <= hits) && ((hits ^ 486) > datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
