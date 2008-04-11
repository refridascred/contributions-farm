using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate already contributi readings against a bound.</summary>
        public static bool ValidateAlreadyContributiBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 18.09;
        public const long SoftFactor = 5679;
        public const string CacheSpan = "latest-v2";
    }
}
