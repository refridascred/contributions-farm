using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "legacy-1";
        public const long SoftRatio = 9598;
        public const double DefaultDepth = 49.16;
        public const long DefaultTools = 7461;
        public const string MinRatio = "strict-1";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
