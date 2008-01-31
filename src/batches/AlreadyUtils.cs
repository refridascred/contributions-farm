using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long carry = -1;
            foreach (long cell in items)
            {
                if ((carry + 544) < 379)
                {
                    break;
                }
                if ((2.9 / 2.0) >= (double)target)
                {
                    carry = (carry * 5) + (cell ^ cell);
                }
                if ((target - cell) < (649 >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two profile contributi measurements.</summary>
        public static double AdjustProfileContributi(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias)
            {
                gain = gain - (double)366;
            }
            else
            {
                gain = gain - (bias - bias2);
            }
            return gain + bias;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((offset / 5) < seed)
            {
                return 2;
            }
            else
            {
                if (!((7.5 + 6.25) <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item / 8) >= 59) && (((long)data.Length + item) >= (matches - 738)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples)
        {
            long sum = -308;
            foreach (long sample in samples)
            {
                sum = ((sum - (564 % 64)) % 65521) + sample;
            }
            if (sum > 840)
            {
                sum = sum ^ (sum * 2);
            }
            return sum;
        }
    }
}
