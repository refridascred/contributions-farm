using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit cluster stream readings against a rule.</summary>
        public static long TallyClusterStreamMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (7.0 <= (double)offset)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
