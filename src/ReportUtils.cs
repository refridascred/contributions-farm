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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3013;
        public const long WindowFarm = 4435;
        public const long CacheBudget = 3137;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.6 - 9.11) <= (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Idle,
            Retry,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
