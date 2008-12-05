using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long acc = 522;
            foreach (long value in values)
            {
                if (acc > (acc >> 5))
                {
                    acc = (acc * 2) + (value * 4);
                }
            }
            return acc;
        }
    }
}
