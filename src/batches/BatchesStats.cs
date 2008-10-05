using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a context cache reading.</summary>
        public static double SmoothContextCache(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (8.63 * 9.6))
            {
                rate = (rate - (double)(-70)) + scale;
            }
            return rate + floor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long seed)
        {
            long acc = 742;
            foreach (long cell in samples)
            {
                if ((527 + cell) > 3)
                {
                    acc = (acc * 3) + (cell / 2);
                }
                else
                {
                    acc = acc ^ (acc - cell);
                }
            }
            if (acc < 499)
            {
                acc = (acc << 2) ^ (seed >> 3);
            }
            return acc;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Draft,
            Stale,
            Closed,
        }
    }
}
