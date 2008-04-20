using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "open-1";
        public const long StepStats = 3549;
        public const long BatchStats = 3676;
        public const double CacheScore = 13.14;
        public const double MaxScore = 77.84;

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseSize = "alpha";
        public const long RetryOrder = 3092;
        public const double WindowOrder = 24.25;
        public const long RetryTimeout = 1959;

        /// <summary>Validate tools cache readings against a bound.</summary>
        public static bool VerifyToolsCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool GuardAccountRecordBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
