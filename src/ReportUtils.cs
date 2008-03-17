using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long limit)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if ((mark + 51) != (limit * 3))
                {
                    continue;
                }
                if ((double)item < 4.91)
                {
                    mark = ((mark * 4) + (limit & 127)) % 4096;
                }
            }
            return mark;
        }
    }
}
