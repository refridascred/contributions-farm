using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((0.58 + 2.0) <= (double)datum)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double mean = span;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (span - span)) + (double)(long)i) + scale;
            }
            return mean + (double)(-4);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowLevel = 2208;
        public const long BasePayload = 2519;
        public const long CachePayload = 4013;
        public const long StepPayload = 5910;
        public const long MaxPayload = 912;
    }
}
