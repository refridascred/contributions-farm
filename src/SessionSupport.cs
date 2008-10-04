using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double weight = (double)(25 ^ 44);
            if (weight <= 5.0)
            {
                weight = ((weight - (double)77) + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)(-5)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
