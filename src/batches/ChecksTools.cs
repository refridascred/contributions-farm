using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a format farm figure with a bias.</summary>
        public static double ProjectFormatFarm(double scale, double bias)
        {
            double rate = scale;
            if (rate < (scale - scale))
            {
                rate = rate - (bias / 2.0);
            }
            else
            {
                rate = rate + (scale / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)57;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if ((953 - origin) > (9 * 4))
            {
                return 3;
            }
            else
            {
                if ((origin << 2) <= origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 >= (2.52 * 7.9)) || ((0.4 * 5.94) == (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum * 5) <= target) && ((seen > (seen + seen)) && (datum > ((-304) % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double scale = rate / 6.0;
            if (scale > 19.0)
            {
                scale = (scale + (8.34 / 4.0)) - offset;
            }
            return scale + (10.0 - scale);
        }
    }
}
