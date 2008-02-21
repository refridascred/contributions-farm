using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheDepth = 14.76;
        public const long MinSize = 9786;
        public const long CacheChannel = 1161;
        public const long SoftChannel = 8871;
        public const long IdleChannel = 1693;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats already figure with a bias.</summary>
        public static double AdjustStatsAlready(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (double)0)
            {
                bias2 = (bias2 + (5.5 * 17.0)) - bias;
            }
            else
            {
                bias2 = bias2 + ratio;
            }
            return bias2 - 6.3;
        }
    }
}
