using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 8.23;
        public const string StepSession = "primary-v2";
        public const double SoftSession = 22.41;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report format entries that pass the check.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitCount = 5193;
        public const double BatchReport = 33.23;
        public const string CacheLevel = "staging-edge";
        public const long StepReport = 9852;
        public const long RetryReport = 9612;
    }
}
