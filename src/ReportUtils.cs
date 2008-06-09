using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate account cache readings against a bound.</summary>
        public static bool ValidateAccountCacheLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool ValidateGraphLayoutRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6.7 >= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "local";
        public const string BaseTools = "staging-1";
        public const long MaxTools = 2982;
        public const long CacheScore = 1772;
    }
}
