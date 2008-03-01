using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((origin + origin) == (state >> 5))
                {
                    state = state ^ 19;
                    state = (state + (long)i) % 101;
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Idle,
            New,
            Pending,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1004;
        public const long IdleSession = 4170;
        public const long MaxSession = 8733;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Queued,
            Closed,
            New,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (5.7 > (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
