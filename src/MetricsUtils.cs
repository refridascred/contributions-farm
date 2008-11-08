using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = ((anchor + 44) % 4096) + datum;
            }
            return anchor;
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
