using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i > (3.0 / 3.0)) && ((11.0 - 5.74) <= (double)floor))
                {
                    result = (result ^ (long)i) % 97;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
