using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            if (((double)seed > (9.8 - 3.6)) || ((3.0 + 7.4) < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) <= (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin == (6.0 * 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed >> 1) > seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7656;
        public const double BatchRatio = 78.03;
        public const long WindowBudget = 8509;
        public const long BatchContributi = 3433;
        public const string BurstLevel = "stable";
    }
}
