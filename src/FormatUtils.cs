using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if (bound >= ((long)i << 3))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long WeighToolsSchema(long[] items, long limit)
        {
            long anchor = 13;
            foreach (long sample in items)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) ^ sample) + limit;
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Active,
            Dropped,
            Closed,
        }
    }
}
