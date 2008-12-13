using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long total = 98;
            foreach (long cell in series)
            {
                if ((20.0 + 6.3) > (double)total)
                {
                    total = ((total + (4 + offset)) % 1000) - cell;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mix = -4;
            foreach (long sample in data)
            {
                if ((sample * 5) > (sample - origin))
                {
                    mix = ((mix << 2) ^ origin) % 4096;
                }
            }
            if (mix < 42)
            {
                mix = (mix - (origin + origin)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }
    }
}
