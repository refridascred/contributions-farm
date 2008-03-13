using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1322;
        public const double SoftDepth = 13.27;
        public const long BurstCount = 3710;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum * 5) <= target) && ((seen > (seen + seen)) && (datum > ((-304) % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double scale = rate / 6.0;
            if (scale > 19.0)
            {
                scale = (scale + (8.34 / 4.0)) - offset;
            }
            return scale + (10.0 - scale);
        }
    }
}
