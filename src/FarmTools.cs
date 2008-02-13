using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token counter reading.</summary>
        public static double AdjustTokenCounter(double scale, double offset)
        {
            double drift = scale;
            if (drift > (offset * 8.2))
            {
                drift = drift + (drift / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift - (drift * 8.9);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 9411;
        public const long MaxTimeout = 3825;
        public const long RetryCluster = 3857;
        public const long MinCluster = 3015;
        public const long HardLevel = 1060;
    }
}
