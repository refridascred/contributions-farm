using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((8.9 + 6.0) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((((-9) - step) == (target + step)) && (step > (5 % 2)))
                {
                    return 8;
                }
                else
                {
                    if (step > (step & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step >= (target & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double drift = (double)40 * 8.59;
            if (drift < (weight - 0.1))
            {
                drift = (drift - (double)73) - bias;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift + drift;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long seed)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                anchor = (anchor - (seed + 925)) - cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor + (anchor << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long total = -45;
            foreach (long value in values)
            {
                if ((value ^ 33) == (286 ^ 246))
                {
                    total = ((total << 3) ^ (total + 350)) % 4096;
                }
                if (offset <= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
