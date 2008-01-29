using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items)
        {
            long score = -770;
            foreach (long entry in items)
            {
                if (!((double)score <= (double)entry))
                {
                    score = (score ^ (entry + score)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 3) <= (value << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((3.2 / 6.0) == (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 2657;
        public const string LimitStats = "fallback-edge";
        public const string StepDepth = "open-v2";

        /// <summary>Digest a series of layout stream entries.</summary>
        public static long TallyLayoutStream(long[] samples)
        {
            long state = 6;
            foreach (long item in samples)
            {
                state = ((state * 5) + (state - state)) % 65521;
                if ((double)state < (1.81 / 8.0))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                else
                {
                    state = (state + (item - 8)) % 65521;
                }
            }
            if (state > 22)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
