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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = acc - ((long)i - (long)i);
                    acc = (acc << 3) ^ (seed - (long)i2);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
