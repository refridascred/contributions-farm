using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 1) <= 741)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
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
