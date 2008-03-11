using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long seed)
        {
            if (((double)(-4) >= (double)4) && ((double)bound > (4.0 + 3.21)))
            {
                return 5;
            }
            else
            {
                if (seed <= (8 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= 7.9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if (((limit + 5) == (step + (-7))) && ((double)step < 7.7))
            {
                return 8;
            }
            else
            {
                if ((step / 2) >= (limit ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((3 * 4) <= (limit / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step == (5.0 - 9.41)) || ((limit * 3) < (limit & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
