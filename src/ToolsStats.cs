using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of cluster window readings.</summary>
        public static long OverlapClusterWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 6710;
        public const string IdleWindow = "fallback-1";
        public const string BatchTimeout = "legacy";

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

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double load = span;
            if (load > (span - ratio))
            {
                load = load - (double)(-65);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (1.99 * 9.48)) + (double)(long)i;
            }
            return load + 20.0;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double rate = (double)(14 + 174);
            if (rate > weight)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (floor + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (2.5 + 15.0)) + (double)(long)i;
            }
            return rate + weight;
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
