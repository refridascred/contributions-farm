using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "cached";
        public const long RetrySpan = 6094;
        public const long WindowRatio = 6852;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            New,
            Dropped,
        }
    }
}
