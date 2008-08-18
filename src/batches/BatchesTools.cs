using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool GuardSupportReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 6972;
        public const long HardLevel = 7403;
        public const string HardRecord = "staging-v2";
        public const long MinRecord = 4634;
        public const long MaxRecord = 1957;

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "staging-1";
        public const long RetryProfile = 1936;
        public const string RetryCount = "open-v2";
        public const long StepLevel = 8700;
        public const long BaseFactor = 1497;
    }
}
