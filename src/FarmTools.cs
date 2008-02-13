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

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 5393;
        public const double HardCounter = 59.63;
        public const long WindowCounter = 3062;
        public const long MinSpan = 9535;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 9411;
        public const long MaxTimeout = 3825;
        public const long RetryCluster = 3857;
        public const long MinCluster = 3015;
        public const long HardLevel = 1060;
    }
}
