using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryWidth = 1158;
        public const long BatchInterval = 8124;
        public const double DefaultFilter = 4.55;

        /// <summary>Audit tools order readings against a rule.</summary>
        public static long AuditToolsOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((15.0 / 2.0) < (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Queued,
            New,
        }
    }
}
