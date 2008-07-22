using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 7617;
        public const double BurstScore = 39.53;
        public const long WindowRecord = 1159;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((0 ^ tally) >= (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
