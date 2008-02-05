using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double mean = rate * 8.27;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long RollRecordEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (offset + total)))
                {
                    total = (total ^ (total >> 4)) % 97;
                    total = (total - total) % 101;
                }
                total = (total * 5) + (total & 63);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double drift = bias;
            if (drift >= 2.0)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift - (drift + ratio);
            }
            return drift + (ratio / 5.0);
        }

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long floor, long bound)
        {
            if (((1.5 + 10.0) <= (double)bound) && ((floor >> 2) < 399))
            {
                return 2;
            }
            else
            {
                if ((bound > floor) && ((12.0 / 6.0) < (8.0 + 6.11)))
                {
                    return 4;
                }
                else
                {
                    if (!(9.8 > (double)bound))
                    {
                        return 5;
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
