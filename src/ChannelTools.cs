using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "open";
        public const double RetryBatches = 89.16;
        public const long BurstSize = 2816;
        public const double BatchBatches = 73.05;
        public const double RetryTimeout = 0.82;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardDepth = 7784;
        public const double LimitSize = 34.43;
        public const long StepQueue = 3722;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((long)series.Length == (target + 955))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
