using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of metrics contributi entries.</summary>
        public static long ScoreMetricsContributi(long[] readings)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((double)anchor > (1.0 * 1.3))
                {
                    anchor = ((anchor ^ (anchor + (long)readings.Length)) % 97) + item;
                }
            }
            return anchor;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long CountCommitsSupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((item + 1) <= matches) && (14 <= (item >> 1))) && (bound >= (item << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Closed,
            Idle,
            Paused,
        }
    }
}
