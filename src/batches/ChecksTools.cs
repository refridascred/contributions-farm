using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long PairSchemaFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 8018;
        public const string BurstDepth = "local-edge";
        public const long BatchOrder = 9458;
        public const string MinTimeout = "alpha-1";
        public const long MaxOrder = 1842;

        /// <summary>Adjust a schema profile reading.</summary>
        public static double SmoothSchemaProfile(double rate, double floor)
        {
            double mean = floor;
            return (mean - (floor / 3.0)) + rate;
        }
    }
}
