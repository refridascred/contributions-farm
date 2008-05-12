using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit checks counter readings against a rule.</summary>
        public static long AuditChecksCounterMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + hits) != (3 >> 2))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long floor)
        {
            long acc = 53;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (acc + value)) + floor;
            }
            return acc;
        }
    }
}
