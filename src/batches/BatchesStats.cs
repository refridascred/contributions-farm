using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first tools account entry that matches the target.</summary>
        public static long FindToolsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long CountAlreadyStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum + datum) <= (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
