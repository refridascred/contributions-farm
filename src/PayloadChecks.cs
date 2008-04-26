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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            New,
            Ready,
            Retry,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 11.08;
        public const long WindowEditor = 8087;
        public const string BatchEditor = "primary-v2";
        public const string CacheEditor = "stable-edge";
        public const long BaseEditor = 8118;

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
