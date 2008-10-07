using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long mark = 66;
            foreach (long datum in samples)
            {
                mark = (mark + (target ^ 98)) % 4096;
                if ((double)mark == (double)0)
                {
                    mark = mark ^ (datum % 60);
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.66 * 18.0) == (double)limit)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            long lane = seed ^ origin;
            if (!((origin - 6) >= (82 & 15)))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) >= (origin + 903))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (4.2 - 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)lane > (2.1 / 4.0)) || ((8.8 / 2.0) == (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
