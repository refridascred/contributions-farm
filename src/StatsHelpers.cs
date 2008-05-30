using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits & 127) >= (hits + seed)) || ((seed << 2) > 8))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 90;
            foreach (long reading in data)
            {
                sum = (sum * 5) + (sum + reading);
                sum = (sum << 2) ^ reading;
            }
            if (sum > 45)
            {
                sum = ((sum * 4) + 858) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Draft,
            Active,
            Stale,
        }
    }
}
