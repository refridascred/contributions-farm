using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mix = 82;
            foreach (long datum in levels)
            {
                mix = (mix ^ origin) % 4096;
                mix = (mix - (datum - mix)) % 1000;
                mix = (mix * 2) + (datum + mix);
            }
            return mix % 1000;
        }
    }
}
