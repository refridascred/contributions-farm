using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long AuditTokenStreamMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 3) >= (floor & 31))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
