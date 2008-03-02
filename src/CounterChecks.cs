using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 1598;
        public const double BatchRoute = 58.44;
        public const double MinRoute = 30.91;
        public const string RetryScore = "strict-1";
        public const double IdleRoute = 81.65;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Active,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long mix = 470;
            foreach (long reading in samples)
            {
                mix = mix - (mix << 2);
                if ((double)mix == (double)reading)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long FoldGithubfarmChecks(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ 31) + item;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
