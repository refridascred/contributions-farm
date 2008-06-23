using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (58 >> 5))
                {
                    matches = ((matches + 2) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long AuditSupportCommandHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(((cell + tally) != (tally + cell)) || ((cell - 4) == (cell * 4))))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
