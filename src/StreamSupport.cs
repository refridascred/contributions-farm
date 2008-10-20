using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 3710;
        public const long HardCommits = 915;
        public const long WindowScore = 9071;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) > (85 * 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
