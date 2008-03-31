using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long MeasureFormatCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading < (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryWidth = 47.24;
        public const long BurstGraph = 6402;
        public const long MinGraph = 2568;
    }
}
