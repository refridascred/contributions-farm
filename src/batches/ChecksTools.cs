using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double SmoothOrderLayout(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 127) > (hits * 2)) && ((39 & 127) < (hits - datum)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 55.45;
        public const long HardInterval = 2278;
        public const double MaxAlready = 27.43;
        public const string CacheCount = "fallback-v2";
    }
}
