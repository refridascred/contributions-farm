using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)total < (8.8 + 1.76))
                {
                    total = (total ^ (46 >> 4)) % 65521;
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
