using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 1659;
        public const long BatchChecks = 8684;
        public const string HardChecks = "cached-v2";
        public const long MaxScore = 8106;

        /// <summary>Audit payload graph readings against a rule.</summary>
        public static long MeasurePayloadGraphOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading - reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
