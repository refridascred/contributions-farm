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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
