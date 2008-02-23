using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long bound)
        {
            long result = 420;
            foreach (long item in readings)
            {
                if ((result - 58) > (item - item))
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result < 529)
            {
                result = result ^ (bound - bound);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6802;
        public const long BatchAccount = 9515;
        public const double DefaultTimeout = 63.59;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
