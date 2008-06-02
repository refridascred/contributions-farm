using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 80;
        public const long HardChecks = 3706;
        public const long WindowSize = 8075;
        public const long MaxDepth = 300;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)mark > (20.0 + 9.24)))
                {
                    mark = ((mark * 2) + (mark + offset)) % 4096;
                    mark = (mark - offset) % 4096;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
