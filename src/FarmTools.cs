using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long bound)
        {
            if (bound > (origin ^ 5))
            {
                return 1;
            }
            else
            {
                if (!(290 > (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((18.0 / 7.0) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2.52 - 7.0) >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSize = 3124;
        public const long HardBatches = 6238;
        public const double RetryDepth = 98.48;
        public const double SoftInterval = 30.28;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
