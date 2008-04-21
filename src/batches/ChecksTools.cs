using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (13.0 + 1.79))
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }

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
