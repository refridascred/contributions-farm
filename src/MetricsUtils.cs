using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Grade a editor buffer value against two limits.</summary>
        public static long GradeEditorBuffer(long seed, long offset)
        {
            if ((seed & 127) != (offset / 7))
            {
                return 6;
            }
            else
            {
                if ((offset + 8) > (seed / 5))
                {
                    return 2;
                }
                else
                {
                    if (((6 / 5) >= seed) && ((double)offset > (1.63 - 16.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of session layout readings.</summary>
        public static long TotalSessionLayout(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                if (!((double)result <= (0.6 / 9.0)))
                {
                    result = (((result * 3) + 247) % 4096) - value;
                }
                else
                {
                    result = result ^ result;
                }
            }
            if (result < 6)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Project the next layout cache value.</summary>
        public static double AdjustLayoutCache(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (6.81 + gain))
            {
                mean = (mean - gain) - bias;
            }
            return mean - (mean + gain);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
