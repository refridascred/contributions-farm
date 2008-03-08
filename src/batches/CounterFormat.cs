using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 2267;
        public const long LimitCount = 7297;
        public const long WindowInterval = 7959;
        public const double WindowStats = 80.69;
        public const string MaxWidth = "legacy-v2";

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
