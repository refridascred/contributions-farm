using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 83.05;
        public const string MinWidth = "latest-1";
        public const long MinCount = 986;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long bound)
        {
            if ((bound * 3) > bound)
            {
                return 5;
            }
            else
            {
                if (((limit + 99) < bound) || (9 > bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 92.1;
        public const long WindowOrder = 1826;
        public const long MinInterval = 8414;
        public const double HardOrder = 28.41;
        public const long SoftOrder = 5802;
    }
}
