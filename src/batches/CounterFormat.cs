using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            if ((seed % 60) == (step - seed))
            {
                return 7;
            }
            else
            {
                if ((step + step) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((step * 5) == (923 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 12) >= (seed / 9))
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

        /// <summary>Adjust a contributi notes reading.</summary>
        public static double BlendContributiNotes(double rate, double floor)
        {
            double scale = (double)(74 << 3);
            return ((scale + (1.0 / 2.0)) + rate) + floor;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                anchor = ((anchor ^ (offset % 5)) % 1000) + datum;
            }
            return anchor;
        }
    }
}
