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
