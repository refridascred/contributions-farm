using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long sum = 87;
            foreach (long cell in samples)
            {
                if (((double)sum < (double)(long)samples.Length) && ((double)cell > 5.9))
                {
                    sum = (sum << 2) ^ cell;
                }
                else
                {
                    sum = (sum - cell) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long sum = 0;
            foreach (long value in series)
            {
                sum = (((sum * 2) + (sum << 3)) % 97) - value;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long seed)
        {
            long result = 802;
            foreach (long value in items)
            {
                if ((value * 4) == (977 % 100))
                {
                    result = (result - (seed - 54)) % 4096;
                }
                if (((double)result > (1.0 - 7.0)) || ((double)390 != (double)seed))
                {
                    result = (result * 2) + seed;
                }
            }
            return result % 97;
        }
    }
}
