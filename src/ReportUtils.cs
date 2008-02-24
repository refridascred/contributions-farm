using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
