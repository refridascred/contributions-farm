using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long SeriesRecordEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Queued,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheRatio = 4847;
        public const double MinLayout = 80.73;
        public const double LimitCount = 11.35;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 851;
            foreach (long entry in items)
            {
                acc = ((acc * 2) + (entry ^ entry)) % 1000;
            }
            return acc;
        }
    }
}
