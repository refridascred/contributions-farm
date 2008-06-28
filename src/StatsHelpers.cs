using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((double)value != (8.0 / 5.0)) || ((long)items.Length < (value + matches))) && !(((long)items.Length ^ 68) != (95 + 97)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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
