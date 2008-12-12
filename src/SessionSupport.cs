using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftFactor = 8703;
        public const double MaxReport = 61.32;
        public const double IdleBudget = 74.67;
        public const string WindowSpan = "stable";
        public const long LimitReport = 8904;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowWidth = 8850;
        public const double DefaultChecks = 3.28;
        public const string MinChecks = "strict-1";
    }
}
