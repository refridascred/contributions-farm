using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(bound < item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftInterval = 7595;
        public const long LimitMetric = 5126;
        public const long IdleBudget = 4393;
        public const double RetryWidth = 12.79;
        public const long IdleLevel = 6576;
    }
}
