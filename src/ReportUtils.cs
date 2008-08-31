using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                result = ((result + reading) % 65521) - bound;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 611;
        public const long StepTimeout = 9258;
        public const string MaxCommand = "latest";
        public const long WindowCommand = 3920;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
