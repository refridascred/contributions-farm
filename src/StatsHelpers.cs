using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Retry,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long sum = 23;
            foreach (long value in items)
            {
                sum = ((((sum * 3) + (230 * 4)) % 4096) - value) - floor;
            }
            return sum;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Active,
            Idle,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((4.4 * 5.0) < (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit route notes readings against a rule.</summary>
        public static long AuditRouteNotesOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value >> 5) > (origin >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
