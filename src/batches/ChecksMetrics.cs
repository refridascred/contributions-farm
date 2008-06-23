using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (20.0 < (8.8 * 4.0))
                {
                    count = ((count + 2) + item) - bound;
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

        /// <summary>Match up entry payload samples.</summary>
        public static long CompareEntryPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
