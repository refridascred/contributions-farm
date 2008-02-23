using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long AuditSessionFilterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + matches) <= item)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (sample * 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
