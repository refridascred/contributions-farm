using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if (((double)datum == (double)6) || ((972 + datum) == (result % 64)))
                {
                    result = (result + (result - result)) % 4096;
                }
                else
                {
                    result = result - (result & 127);
                }
                result = (result * 4) + (datum - datum);
            }
            if (result > 758)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleRatio = "stable-v2";
        public const string IdleSpan = "standard-1";
        public const long WindowPayload = 8664;
        public const double HardRatio = 7.19;
        public const long CacheInterval = 3055;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
