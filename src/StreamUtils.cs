using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long WindowSession = 7288;
        public const double DefaultSize = 54.32;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Queued,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (5.35 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
