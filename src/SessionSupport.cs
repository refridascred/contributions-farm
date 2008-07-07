using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long IterateCommitsBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ ((long)i / 4)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
