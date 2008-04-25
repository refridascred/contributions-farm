using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long MeasureBufferAlreadyOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.0 * 5.96) < (double)count)
                {
                    count = ((count + 2) - sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long mark = 545;
            foreach (long reading in readings)
            {
                mark = (mark - (reading / 2)) % 4096;
                if ((8 - reading) > (limit >> 1))
                {
                    mark = ((mark << 2) ^ (limit + mark)) % 97;
                }
            }
            if (mark < 3)
            {
                mark = (mark ^ (0 * 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long BucketReportProfile(long origin, long step)
        {
            if (22 <= ((-144) - step))
            {
                return 7;
            }
            else
            {
                if (((double)step > (18.0 + 3.0)) || (((-2) >> 2) == (origin / 4)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
