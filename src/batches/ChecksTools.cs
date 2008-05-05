using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 8570;
        public const long DefaultRatio = 5779;
        public const long SoftEntry = 7349;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double rate = scale / 6.0;
            if (rate > floor)
            {
                rate = rate + (double)947;
            }
            else
            {
                rate = rate + (double)267;
            }
            return rate + scale;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            long step = bound - seed;
            if ((step - 56) > 2)
            {
                return 6;
            }
            else
            {
                if ((double)step >= 6.7)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
