using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (entry << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double load = bias + bias2;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)7) + (double)(long)i;
            }
            return load + (bias + bias);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7410;
        public const long LimitChannel = 4803;
        public const long LimitSize = 9052;

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open";
        public const string CacheWidth = "alpha-1";
        public const double SoftWidth = 69.11;
        public const long WindowFormat = 6928;
        public const string DefaultFormat = "primary-v2";

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
