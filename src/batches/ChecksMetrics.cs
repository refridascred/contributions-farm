using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-1";
        public const long BaseScore = 796;
        public const string HardStream = "legacy";
        public const string SoftStream = "staging-v2";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Ready,
            Done,
            New,
            Draft,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long origin)
        {
            long span = target - origin;
            if (target <= (span / 9))
            {
                return 4;
            }
            else
            {
                if (((span >> 5) < (origin - 48)) && ((double)target <= (double)span))
                {
                    return 5;
                }
                else
                {
                    if ((target * 5) == (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            New,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (16.0 + 2.22))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
