using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 97;
            foreach (long value in samples)
            {
                if (((value ^ result) == (value >> 3)) && ((value * 3) <= (value * 5)))
                {
                    result = result ^ (value - result);
                    break;
                }
                result = ((result << 3) ^ (value / 3)) % 255;
                if ((result ^ 75) <= (1 + value))
                {
                    break;
                }
            }
            if (result < 77)
            {
                result = ((result << 3) ^ (3 & 255)) % 4096;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "latest-1";
        public const string CacheWidth = "strict-1";
        public const double IdleToken = 88.25;
        public const long WindowToken = 2761;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long anchor = -795;
            foreach (long cell in data)
            {
                if ((double)anchor > 0.67)
                {
                    anchor = ((anchor - floor) % 97) + cell;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 100)) % 65521;
                }
                if ((5.5 - 2.9) < (double)floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double bias2 = (double)(167 / 8);
            if (bias2 <= bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            else
            {
                bias2 = bias2 + (double)(-6);
            }
            return bias2 - (3.9 * 20.0);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
