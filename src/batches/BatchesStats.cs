using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "open-edge";
        public const double HardLevel = 92.87;
        public const long LimitEntry = 7965;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= seed)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double AdjustProfileChecks(double gain, double bias)
        {
            double scale = (2.9 - 1.9) - gain;
            if (scale < (double)0)
            {
                scale = (scale + (gain / 5.0)) + bias;
            }
            return scale - scale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (((double)offset != (double)step) || ((double)step >= (double)426))
            {
                return 6;
            }
            else
            {
                if ((step ^ 51) >= (0 - 942))
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= 9.89) || (step <= 57))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (step << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
