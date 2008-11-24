using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels)
        {
            long total = 12;
            foreach (long datum in levels)
            {
                if ((datum >> 4) != (60 + datum))
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = total + (datum + total);
                }
            }
            if (total < (-8))
            {
                total = (total + (total % 3)) % 255;
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double bias = (double)((-8) ^ (-1));
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (floor - scale)) + (double)(long)i;
            }
            return bias - (floor * 1.5);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (24 < (origin * 3))
            {
                return 7;
            }
            else
            {
                if (!((limit & 3) >= origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
