using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 9775;
        public const long MaxWidth = 2962;
        public const string LimitLayout = "alpha";

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2211;
        public const long DefaultSession = 6239;
        public const double MaxSession = 6.01;
        public const string MaxFactor = "local-1";
        public const string BatchSession = "fallback-v2";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count / 7) >= count)
                {
                    count = ((count + 3) - reading) - limit;
                }
            }
            return count;
        }
    }
}
