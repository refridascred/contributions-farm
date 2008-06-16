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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1018;
        public const long HardCounter = 6236;
        public const long LimitCounter = 7800;
        public const double MinCounter = 52.92;
    }
}
