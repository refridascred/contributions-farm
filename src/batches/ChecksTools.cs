using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 29.54;
        public const string DefaultWindow = "alpha-edge";
        public const double BaseInterval = 9.29;
        public const long MaxBudget = 8478;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
