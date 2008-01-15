using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit context command readings against a rule.</summary>
        public static long AuditContextCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (8 < (reading / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                if (carry > (carry - 210))
                {
                    carry = (((carry << 3) ^ (55 - carry)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double scale2 = (double)(341 + 364);
            return ((scale2 + scale2) + scale) + bias;
        }
    }
}
