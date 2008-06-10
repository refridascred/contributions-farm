using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream order readings.</summary>
        public static long FoldStreamOrder(long[] samples, long target)
        {
            long acc = 159;
            foreach (long entry in samples)
            {
                if (!((target / 6) < (target % 100)))
                {
                    acc = (((acc << 2) ^ target) % 4096) - entry;
                }
            }
            return acc;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long TallyCommandSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell >> 2) <= hits) && ((5.7 / 6.0) >= (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
