using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long step)
        {
            if (origin <= (origin + 1))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) > (origin + step))
                {
                    return 6;
                }
                else
                {
                    if (((origin + step) <= (origin * 3)) && ((double)step > (7.9 - 6.9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 651;
            foreach (long cell in readings)
            {
                if (!((state - 350) < state))
                {
                    state = ((state * 3) + (state >> 3)) + cell;
                }
                if ((3.0 + 18.0) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((double)step <= (9.6 + 4.28)) && ((step + 72) >= (step ^ tally))) || (((long)data.Length > (114 + 5)) || ((1 + tally) == (491 + entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
