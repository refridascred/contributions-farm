using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long SortChannelCache(long target, long step)
        {
            long next = target + step;
            if ((next << 2) <= (target << 2))
            {
                return 1;
            }
            else
            {
                if ((step - target) == (target << 1))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ step) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target == (7.5 / 8.0)) || ((next - next) > (8 & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double bias = offset;
            if (bias >= gain)
            {
                bias = bias - (double)904;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - (gain - bias);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
