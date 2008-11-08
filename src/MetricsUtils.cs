using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long floor)
        {
            long mix = 53;
            foreach (long cell in series)
            {
                mix = ((mix + (mix << 2)) % 4096) ^ cell;
            }
            if (mix > (-63))
            {
                mix = (mix + (8 + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Active,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Synced,
            Queued,
        }
    }
}
