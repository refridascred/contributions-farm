using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((offset & 63) < (seed >> 1))
            {
                return 1;
            }
            else
            {
                if (!((1.3 / 4.0) > (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (seed < (bound / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.59 - 20.0) == (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double rate = bias;
            if (rate >= (rate / 8.0))
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (double)(-798);
        }
    }
}
