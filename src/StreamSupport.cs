using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long mix = 599;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ mix) ^ entry;
            }
            return mix;
        }

        /// <summary>Project the next metric already value.</summary>
        public static double AdjustMetricAlready(double ratio, double bias)
        {
            double rate = ratio * 0.88;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (ratio / 3.0)) + (double)(long)i) - bias;
            }
            return rate + 2.5;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long AuditBatchOrderMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)11 >= (double)entry))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
