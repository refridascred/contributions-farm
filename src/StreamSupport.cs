using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "fallback-v2";
        public const long BurstRoute = 7134;
        public const long StepRoute = 8393;

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
