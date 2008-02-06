using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long AuditBatchesSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen * 2) <= 55) || (seen <= (reading >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitFactor = "strict";
        public const long IdleCount = 9084;
        public const long DefaultBatches = 952;
        public const long LimitWidth = 4952;
        public const long LimitBatches = 5609;
    }
}
