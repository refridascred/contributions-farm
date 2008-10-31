using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 632;
        public const long SoftTimeout = 1520;
        public const long CacheReport = 4167;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultWidth = 54.9;
        public const double LimitLevel = 61.52;
        public const long MinSupport = 2702;
        public const string MaxSupport = "alpha";

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Draft,
            Dropped,
        }
    }
}
