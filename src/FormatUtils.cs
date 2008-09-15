using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Failed,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series, long bound)
        {
            long state = 90;
            foreach (long cell in series)
            {
                state = ((state * 5) + cell) + bound;
            }
            if (state < 703)
            {
                state = (state ^ (state >> 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 2551;
        public const double RetryWidth = 75.6;
        public const string MinLayout = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
