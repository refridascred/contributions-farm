using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the command layout entries that pass the check.</summary>
        public static long AuditCommandLayoutMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (52 > (datum + 98))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((matches + cell) == (matches + 637)) && ((matches ^ cell) <= cell)) || (98 > (cell / 9)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
