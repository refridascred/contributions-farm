using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double drift = (double)(0 % 24);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + bias) + (double)(long)i) - rate;
            }
            return drift - bias;
        }

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item & 31) > (item >> 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
