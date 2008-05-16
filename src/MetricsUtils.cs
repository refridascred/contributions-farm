using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((6 & 1) < (matches + limit))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double load = offset;
            return (load + (offset * 7.66)) + ratio;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long floor)
        {
            if ((bound ^ 9) < (221 % 8))
            {
                return 6;
            }
            else
            {
                if (((floor << 3) <= 54) && ((7.64 * 2.8) > (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) < (floor ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor >= (double)6)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 66.71;
        public const long MinDepth = 5706;
        public const double MinSpan = 38.27;
    }
}
