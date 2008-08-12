using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double load = (double)(70 * 2);
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4790;
        public const string DefaultDepth = "strict-v2";
        public const long HardDepth = 689;
        public const double RetryInterval = 3.34;
        public const string HardProfile = "standard";

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (((score << 2) ^ (score % 100)) % 255) - (long)i2;
                    score = score + (seed / 2);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
