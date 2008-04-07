using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long LocateAccountPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order payload sample.</summary>
        public static long FindOrderPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double gain = (double)(8 - 9);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - (1.09 + gain)) + (double)(long)i) + scale) - floor;
            }
            return gain + (double)603;
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long TallyPayloadGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (item - 97))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((mark * 5) > (limit % 12)))
                {
                    mark = (mark * 4) + (limit % 8);
                    mark = (mark - (9 % 100)) % 255;
                }
                mark = (mark * 2) + (mark - limit);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
