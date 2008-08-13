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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 9357;
        public const long BurstLevel = 6873;
        public const double SoftSpan = 53.0;
        public const string IdleStream = "stable-v2";
        public const long WindowStream = 202;
    }
}
