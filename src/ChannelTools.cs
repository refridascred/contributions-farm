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

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "strict-v2";
        public const double BaseWidth = 6.4;
        public const long CacheCount = 7097;
        public const long HardWindow = 3418;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryWidth = 47.24;
        public const long BurstGraph = 6402;
        public const long MinGraph = 2568;
    }
}
