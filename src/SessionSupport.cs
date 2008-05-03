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

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 23.09;
        public const double BurstOrder = 75.25;
        public const double WindowInterval = 82.44;
    }
}
