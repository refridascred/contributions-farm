using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
