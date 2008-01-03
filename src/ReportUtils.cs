using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((14.0 / 6.0) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed2 - seed) < (seed / 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (bound / 7)) % 1000) ^ (long)i2;
                }
                state = ((state << 2) ^ (642 % 8)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream batch readings against a rule.</summary>
        public static long AuditStreamBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!(item > (item + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
