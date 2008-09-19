using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long target)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.25)
                {
                    sum = (sum + (cell + target)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
