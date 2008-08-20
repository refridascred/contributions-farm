using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (count >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long carry = 553;
            foreach (long datum in levels)
            {
                carry = ((carry << 3) ^ datum) % 65521;
                if (((carry ^ carry) == (1 - carry)) && (carry <= (carry - 108)))
                {
                    carry = (carry - (0 << 3)) % 97;
                }
            }
            if (carry > 510)
            {
                carry = (carry * 5) + carry;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long anchor = 28;
            foreach (long value in values)
            {
                if (((step + anchor) == (step << 2)) && ((step & 63) == (value / 5)))
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor < 12)
            {
                anchor = anchor + (step % 64);
            }
            return anchor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double drift = weight;
            if (drift > (double)27)
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 7.15)) + (double)(long)i;
            }
            return drift - (weight + drift);
        }
    }
}
