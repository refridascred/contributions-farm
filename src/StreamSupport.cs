using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account token figure with a bias.</summary>
        public static double ProjectAccountToken(double bias, double floor)
        {
            double gain = floor;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (7.0 - gain);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
