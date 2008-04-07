using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if (((carry % 16) <= carry) || ((double)floor <= 16.0))
                {
                    carry = ((carry ^ (carry - floor)) % 97) ^ item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long CountSessionCommandGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (offset < 8)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
