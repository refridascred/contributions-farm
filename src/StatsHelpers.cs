using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Draft,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long SortBufferRoute(long seed, long offset)
        {
            if ((offset << 3) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset <= (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (6.3 + 9.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.3 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ offset) ^ reading;
            }
            if (sum < 0)
            {
                sum = (sum + (994 + sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits < (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
