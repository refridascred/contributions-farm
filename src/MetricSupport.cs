using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheCount = 7.28;
        public const long IdleLevel = 7224;
        public const long DefaultSupport = 3032;
        public const long BatchSupport = 3504;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 95.43;
        public const long StepBudget = 3904;
        public const string CacheNotes = "standard";
        public const long StepNotes = 3490;
        public const long MaxNotes = 5912;
    }
}
