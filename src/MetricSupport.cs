using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 255) ^ cell) + step;
            }
            if (result < 3)
            {
                result = (result + (long)samples.Length) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Synced,
            Locked,
            Dropped,
            Ready,
        }
    }
}
