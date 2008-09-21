using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Idle,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Closed,
            New,
            Queued,
            Locked,
        }
    }
}
