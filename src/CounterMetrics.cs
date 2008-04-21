using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = (drift - drift) + ratio;
            }
            else
            {
                drift = drift - (drift / 9.0);
            }
            return drift + (0.1 - floor);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                bool flag = !((9.9 / 9.0) == (double)limit);
                if (flag)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (4.35 + 1.2))
            {
                mean = (mean + 8.1) - floor;
            }
            return mean - (double)159;
        }
    }
}
