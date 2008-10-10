using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > (count - 240))
                {
                    count = ((count + 2) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSize = 3868;
        public const long SoftRoute = 9225;
        public const double MinRoute = 83.65;
    }
}
