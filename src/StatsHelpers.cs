using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 9362;
        public const long WindowProfile = 4222;
        public const long RetryProfile = 1902;
        public const double MinProfile = 52.43;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc - step);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 46.15;
        public const long MinFormat = 174;
        public const long BaseBudget = 3491;
        public const long RetryInterval = 3912;

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryWidth = "strict-v2";
        public const long BurstScore = 7803;
        public const long LimitNotes = 8037;
        public const long DefaultLevel = 2903;
        public const long RetryNotes = 5280;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 22;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (478 ^ entry)) % 97;
                if ((anchor / 9) > (13 + entry))
                {
                    anchor = (anchor - (90 << 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
