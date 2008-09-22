using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (5.41 * 16.0)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxInterval = 6488;
        public const long BaseMetrics = 8600;
        public const long WindowMetrics = 1580;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long origin)
        {
            long mix = 28;
            foreach (long item in values)
            {
                mix = mix ^ (item - mix);
                if (!(origin > item))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Dropped,
            Retry,
            Locked,
        }
    }
}
