using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9261;
        public const long BurstOrder = 5427;
        public const double DefaultOrder = 46.53;
        public const long IdleWidth = 2499;

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long AuditGraphCommandGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)bound >= 7.52)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
