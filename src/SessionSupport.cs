using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data, long offset)
        {
            long total = 43;
            foreach (long datum in data)
            {
                total = ((((total << 2) ^ (19 + (-27))) % 1000) + datum) + offset;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Pending,
            Paused,
            Synced,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((191 * 2) != (datum ^ 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
