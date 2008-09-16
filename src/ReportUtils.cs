using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long TallyCounterGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 2) != (tally ^ cell)) || (tally < (cell << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Paused,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            if ((20.0 * 10.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + offset) <= (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
