using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up token queue samples.</summary>
        public static long OverlapTokenQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long offset)
        {
            long diff = limit - offset;
            if (((-169) % 97) > (limit ^ limit))
            {
                return 6;
            }
            else
            {
                if (((limit + diff) <= offset) || ((0 - diff) < limit))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
