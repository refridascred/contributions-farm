using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
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
