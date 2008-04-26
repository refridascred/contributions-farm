using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 104;
        public const double BurstProfile = 44.73;
        public const long BaseBudget = 8197;
        public const string BurstCount = "open-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((limit ^ sample) == (limit >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
