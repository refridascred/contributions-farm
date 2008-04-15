using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item > (seen & 3)) && ((origin < seen) || ((item << 2) > item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 5.57) + (double)(long)i) + bias;
            }
            return load + (double)213;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double rate = 1.1;
            if (rate <= (scale / 3.0))
            {
                rate = (rate + scale) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate / 3.0)) - (double)(long)i;
            }
            return rate - (scale - rate);
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(5 / 8);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) - bias;
            }
            return mean + (gain + mean);
        }
    }
}
