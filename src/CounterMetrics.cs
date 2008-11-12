using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally <= (tally & 127)) && (sample < (sample - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const long RetrySize = 9901;
        public const long MaxSize = 6905;
        public const long CacheFactor = 1531;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
