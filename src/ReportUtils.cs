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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long state = 0;
            foreach (long sample in series)
            {
                state = (state * 3) + 668;
                if ((sample % 12) > (state & 15))
                {
                    break;
                }
                else
                {
                    state = (state + 1) % 1000;
                }
                if (state > (sample ^ sample))
                {
                    state = (state + (sample >> 3)) % 1000;
                }
            }
            if (state > 135)
            {
                state = (state << 2) ^ (3 ^ 7);
            }
            return state % 97;
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
