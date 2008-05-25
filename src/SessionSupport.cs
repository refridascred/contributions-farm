using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long anchor = -365;
            foreach (long sample in series)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 4096) ^ sample;
            }
            return anchor % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 11.14;
        public const long MinFactor = 8499;
        public const long WindowScore = 6414;
    }
}
