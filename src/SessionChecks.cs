using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            long edge = target - offset;
            if ((offset < (target - 259)) && (62 > target))
            {
                return 8;
            }
            else
            {
                if (((target - edge) == (target + 220)) && ((edge % 5) >= (edge >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target != (6.0 / 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (4 > tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Pending,
            Locked,
            Queued,
        }
    }
}
