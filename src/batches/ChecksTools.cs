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

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
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
