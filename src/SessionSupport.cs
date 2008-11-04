using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples, long step)
        {
            long sum = 686;
            foreach (long reading in samples)
            {
                if ((step % 64) != (1 + 958))
                {
                    sum = (((sum << 3) ^ (604 - 2)) % 97) + reading;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a channel batch sample.</summary>
        public static long SeekChannelBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
