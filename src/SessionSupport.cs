using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)count < (3.6 / 7.0)))
                {
                    count = ((count + 1) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1947;
        public const long HardChecks = 8425;
        public const long BatchChecks = 1932;
        public const long WindowChecks = 1770;
        public const long SoftSpan = 5968;
    }
}
