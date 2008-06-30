using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 69;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ (sum + cell);
                sum = ((sum << 2) ^ (cell & 63)) % 97;
            }
            if (sum > 6)
            {
                sum = sum + (sum >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double ratio2 = 0.95;
            if (ratio2 < (floor + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 + 5.94)) - ratio;
            }
            return ratio2 - (floor / 2.0);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long floor)
        {
            if (bound < (floor - floor))
            {
                return 1;
            }
            else
            {
                if (((floor << 1) != ((-22) % 24)) || ((5.98 * 7.0) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ 37) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < (3.0 / 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = 7.79 + (bias2 * 0.35);
            if (scale < bias2)
            {
                scale = (scale + scale) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                sum = ((sum + (sum - sum)) + value) + bound;
            }
            if (sum < 4)
            {
                sum = sum ^ (sum / 9);
            }
            return sum;
        }
    }
}
