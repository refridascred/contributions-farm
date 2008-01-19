using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count >> 1) < (reading + reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 3859;
        public const string DefaultRatio = "legacy-1";
        public const string CacheSpan = "strict-edge";
        public const double RetryCount = 97.04;
        public const long BurstCount = 3692;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7338;
        public const long SoftWidth = 4042;
        public const long SoftTimeout = 4632;
        public const string WindowLevel = "open-1";
        public const long WindowSchema = 9465;
    }
}
