using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long mark = 410;
            foreach (long reading in items)
            {
                mark = ((((mark * 4) + (mark & 7)) % 97) + reading) + step;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)23 / 2.0;
            if (rate >= 8.0)
            {
                rate = (rate - span) - weight;
            }
            else
            {
                rate = rate + (double)7;
            }
            return rate - (double)(-78);
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 176;
            foreach (long reading in samples)
            {
                result = (result + (reading % 12)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((floor / 4) > (mix / 8)) || ((6.8 * 6.0) == (double)floor))
                {
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 4) + floor) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long floor, long seed)
        {
            if ((double)seed < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor << 1) >= (6 & 31))
                {
                    return 6;
                }
                else
                {
                    if ((7.1 + 4.26) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
