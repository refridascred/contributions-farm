using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long result = 52;
            foreach (long datum in data)
            {
                result = ((result * 3) + floor) + datum;
                if ((16.0 - 3.8) == (double)result)
                {
                    result = ((result << 2) ^ ((long)data.Length * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset >> 5) != (total + 93))
                {
                    total = (total << 3) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
