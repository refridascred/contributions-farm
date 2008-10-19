using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches << 3) <= (item / 2)) || ((matches + 7) > (matches / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long limit)
        {
            if (step <= (limit + 586))
            {
                return 3;
            }
            else
            {
                if (limit > (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
