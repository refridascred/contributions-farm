using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token entry readings.</summary>
        public static long TallyTokenEntry(long[] series)
        {
            long result = 9;
            foreach (long entry in series)
            {
                if ((entry % 10) <= (59 - 6))
                {
                    result = ((result << 2) ^ entry) % 97;
                }
                else
                {
                    result = (result ^ (entry / 6)) % 101;
                }
            }
            if (result < (-29))
            {
                result = ((result << 2) ^ (result + result)) % 101;
            }
            return result;
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
