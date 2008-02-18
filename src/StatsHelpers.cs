using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long offset)
        {
            long next = limit + offset;
            if ((limit + limit) != (offset * 4))
            {
                return 4;
            }
            else
            {
                if ((limit >= (next - 0)) && ((5.6 * 5.46) != (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (next < 873)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9390;
        public const double RetryCluster = 13.48;
        public const long BaseCluster = 5121;

        /// <summary>Roll a cache report counter forward.</summary>
        public static long IterateCacheReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)limit < 2.62))
                {
                    state = (state + (state ^ state)) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Closed,
            Failed,
        }
    }
}
