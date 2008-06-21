using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of metrics order entries.</summary>
        public static long DigestMetricsOrder(long[] levels, long limit)
        {
            long state = -489;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 3) ^ (state - cell)) % 1000) - (long)i;
                }
                if ((cell ^ state) <= limit)
                {
                    state = state + (state - limit);
                }
                else
                {
                    state = ((state * 2) + limit) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
