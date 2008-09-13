using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long mix = 116;
            foreach (long cell in series)
            {
                mix = (mix + cell) % 4096;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)floor > (9.6 / 5.0)) && ((0 + floor) >= ((long)data.Length / 2)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
