using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((-21) >= (entry - (-3))) && ((double)origin != (3.7 / 5.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next profile stream value from a seed.</summary>
        public static long RollProfileStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
