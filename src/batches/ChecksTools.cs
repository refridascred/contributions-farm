using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }

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
