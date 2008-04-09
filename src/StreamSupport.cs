using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (target <= 4)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
