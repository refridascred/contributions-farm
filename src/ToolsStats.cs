using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry / 6) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 2485;
        public const long HardWidth = 7499;
        public const long StepAlready = 5669;
        public const long HardAlready = 3764;
        public const double MinAlready = 54.48;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long CountBatchesAccountGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
