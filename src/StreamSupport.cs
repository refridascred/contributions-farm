using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long limit)
        {
            long total = 99;
            foreach (long value in items)
            {
                if ((3.7 / 8.0) > (double)value)
                {
                    total = (total ^ limit) % 97;
                }
                if ((double)limit <= 0.7)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) < (cell & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
