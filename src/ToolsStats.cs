using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Derive the next counter queue value from a seed.</summary>
        public static long SeriesCounterQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches % 97) <= matches)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 43.75;
        public const long MaxSpan = 6687;
        public const string SoftCount = "cached-1";
        public const long BatchTools = 143;
        public const long WindowTools = 8376;
    }
}
