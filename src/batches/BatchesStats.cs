using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Closed,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Iterate the report contributi series from a seed.</summary>
        public static long IterateReportContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((total ^ (long)i) == (long)i) && (3.59 >= (double)total)))
                {
                    total = ((total * 3) + (limit + total)) % 255;
                    total = ((total << 3) ^ (limit << 2)) % 1000;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
