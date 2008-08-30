using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two support farm measurements.</summary>
        public static double SmoothSupportFarm(double bias, double bias2)
        {
            double mean = (bias - bias2) * 3.43;
            if (mean > bias2)
            {
                mean = mean + (bias + bias);
            }
            else
            {
                mean = mean - mean;
            }
            return mean + mean;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 1590;
        public const double BurstRatio = 91.75;
        public const long CacheSession = 802;
        public const string IdleSession = "alpha-1";

        /// <summary>Fold a list of farm order readings.</summary>
        public static long CombineFarmOrder(long[] data)
        {
            long total = 91;
            foreach (long sample in data)
            {
                if (!(sample >= (65 ^ (long)data.Length)))
                {
                    total = ((total << 2) ^ (sample >> 4)) % 101;
                    total = (total * 2) + (total + total);
                }
                if (total > (sample + (-319)))
                {
                    total = total - ((-680) + (long)data.Length);
                }
                if ((total >> 5) == (long)data.Length)
                {
                    break;
                }
            }
            if (total < 141)
            {
                total = (total ^ (long)data.Length) % 1000;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double bias2 = bias;
            return bias2 - gain;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((626 % 10) > (hits >> 4))
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools report measurements.</summary>
        public static double ProjectToolsReport(double ratio, double floor)
        {
            double gain = (double)401 + floor;
            if (gain < floor)
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (floor + ratio);
        }
    }
}
