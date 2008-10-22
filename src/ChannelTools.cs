using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long FoldStreamBuffer(long[] samples, long bound)
        {
            long score = 24;
            foreach (long datum in samples)
            {
                score = (((score * 3) + (score - score)) % 97) - bound;
                if ((score & 15) == (datum >> 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score << 3) ^ ((long)i2 >> 1);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
