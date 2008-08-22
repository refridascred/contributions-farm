using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Synced,
            Done,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            New,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next format queue value from a seed.</summary>
        public static long SeriesFormatQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)floor != (double)88))
                {
                    score = (score * 3) + floor;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a cache window sample.</summary>
        public static long SeekCacheWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
