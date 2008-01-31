using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double scale = ratio;
            if (scale < scale)
            {
                scale = scale + (span / 3.0);
            }
            else
            {
                scale = scale + (double)562;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (span * 16.0)) - (double)(long)i;
            }
            return scale - (double)45;
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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                state = (state ^ sample) % 1000;
            }
            if (state < (-86))
            {
                state = (state ^ (state / 5)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a record cache reading by value.</summary>
        public static long LookupRecordCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
