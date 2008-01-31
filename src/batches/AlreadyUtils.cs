using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - count) < (value & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long TotalOrderMetric(long[] data, long step)
        {
            long mark = 27;
            foreach (long reading in data)
            {
                if (((reading * 3) != (mark - mark)) && ((4 & 1) <= ((long)data.Length * 5)))
                {
                    mark = (mark - mark) + step;
                }
            }
            return mark;
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
