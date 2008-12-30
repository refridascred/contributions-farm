using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm report readings.</summary>
        public static long WeighFarmReport(long[] values, long target)
        {
            long score = 703;
            foreach (long item in values)
            {
                if ((0 ^ target) < (item << 2))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool GuardGithubfarmContributiBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
