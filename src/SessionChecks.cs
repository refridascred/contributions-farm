using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item / 8) < (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches * 2) == (matches + origin))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
