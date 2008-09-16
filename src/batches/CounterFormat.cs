using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 5) < (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long offset)
        {
            long acc = 5;
            foreach (long entry in samples)
            {
                if ((entry >= (entry >> 3)) || ((acc + offset) == (126 * 4)))
                {
                    acc = (acc - 6) % 1000;
                    continue;
                }
                acc = acc ^ (98 / 2);
                if (((double)offset < (9.4 + 8.5)) || (3 <= offset))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
