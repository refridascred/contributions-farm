using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1616;
        public const long BaseInterval = 9773;
        public const string DefaultScore = "staging-edge";
        public const long SoftInterval = 8143;
        public const long SoftReport = 1249;

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
