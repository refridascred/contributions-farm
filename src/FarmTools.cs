using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (mix + mix)) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix - ((long)i2 + offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double mean = (floor - rate) - (double)722;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean * 3.6)) + (double)(long)i;
            }
            return mean + (mean - rate);
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((span + limit) >= (span - span))
            {
                return 4;
            }
            else
            {
                if (((limit2 + limit) == (limit - limit)) && ((92 + limit2) >= span))
                {
                    return 1;
                }
                else
                {
                    if (!((limit2 % 2) <= limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
