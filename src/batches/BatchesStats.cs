using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "strict";
        public const double BatchOrder = 58.3;
        public const string HardOrder = "primary-v2";

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally <= ((long)values.Length * 3))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4788;
        public const double RetryFilter = 6.21;
        public const long BaseFilter = 3906;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultFilter = 9689;
    }
}
