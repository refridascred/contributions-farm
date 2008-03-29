using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftScore = 20.18;
        public const long CacheDepth = 2903;
        public const string MaxGraph = "local-edge";
        public const long BurstSize = 4649;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] data)
        {
            long sum = 232;
            foreach (long item in data)
            {
                sum = ((sum * 3) + (item / 5)) % 97;
                sum = (sum - (238 + sum)) % 255;
                sum = ((sum << 2) ^ (-83)) % 97;
            }
            return sum;
        }
    }
}
