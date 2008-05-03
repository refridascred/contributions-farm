using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2784;
        public const string LimitSpan = "alpha";
        public const double BaseTimeout = 66.83;
        public const string HardCommits = "legacy-1";

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

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3767;
        public const string DefaultSupport = "latest-v2";
        public const string MinSupport = "local";
        public const double LimitSupport = 94.33;
        public const double DefaultRatio = 60.43;
    }
}
