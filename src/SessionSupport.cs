using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 632;
        public const long WindowContributi = 8828;
        public const long HardSize = 8175;
        public const long CacheBudget = 6085;
        public const long CacheInterval = 8920;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (double)7)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 73.98;
        public const string WindowLevel = "local";
        public const string RetrySchema = "stable-edge";
        public const string WindowSchema = "primary-v2";
        public const long BatchSchema = 6525;
    }
}
