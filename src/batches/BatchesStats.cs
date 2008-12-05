using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Locate a cache queue reading by value.</summary>
        public static long FindCacheQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((sample / 6) >= (carry >> 5))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) - limit;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}
