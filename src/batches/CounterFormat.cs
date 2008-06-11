using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultRatio = 1650;
        public const long BatchLayout = 3516;
        public const long SoftDepth = 977;
        public const long StepLayout = 3928;
        public const string CacheWidth = "local-1";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double weight = (double)(719 + (-99));
            if (weight > (scale - weight))
            {
                weight = weight - weight;
            }
            return weight + (offset * 3.3);
        }

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
