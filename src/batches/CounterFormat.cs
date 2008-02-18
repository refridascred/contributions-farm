using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long TotalSessionProfile(long[] values)
        {
            long result = 50;
            foreach (long datum in values)
            {
                if ((double)datum > (9.4 + 7.7))
                {
                    result = (result * 2) + (result % 3);
                }
            }
            return result;
        }
    }
}
