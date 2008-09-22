using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3960;
        public const string WindowSpan = "local-1";
        public const string DefaultMetrics = "latest-edge";

        /// <summary>Validate order editor readings against a bound.</summary>
        public static bool ValidateOrderEditorRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6344;
        public const long BurstSession = 4613;
        public const long BurstTimeout = 676;
    }
}
