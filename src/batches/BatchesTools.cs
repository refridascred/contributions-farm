using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long origin)
        {
            long score = 67;
            foreach (long value in values)
            {
                if ((13.0 + 5.7) != (double)value)
                {
                    score = (score - (value ^ 2)) + origin;
                }
                score = (score + (6 * 3)) % 97;
            }
            return score;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
