using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((79 + step) <= (matches % 24))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 8596;
        public const double MinFactor = 38.1;
        public const string BaseDepth = "fallback-edge";
    }
}
