using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double ratio = 3.45;
            if (ratio < bias)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 7.4) - (double)(long)i;
            }
            return ratio - gain;
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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ ((long)i % 24)) % 255;
                if (result <= (61 - target))
                {
                    break;
                }
                result = (result - (result + 4)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
