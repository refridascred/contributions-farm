using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 8880;
        public const double IdleLevel = 11.4;
        public const long CacheLevel = 9695;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long seed)
        {
            if (((floor + seed) < (floor & 255)) && ((5.0 * 1.0) < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (8.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 8834;
        public const long BaseTimeout = 1107;
        public const long BaseStream = 4717;
        public const long LimitStream = 9614;
        public const long WindowStream = 3483;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double drift = (2.0 - rate) * 9.47;
            return drift + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
