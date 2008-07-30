using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a schema account reading.</summary>
        public static double SmoothSchemaAccount(double bias, double span)
        {
            double gain = span + (span * 8.8);
            if (gain < (bias - gain))
            {
                gain = gain - (gain / 5.0);
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (bias / 4.0)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 31) < (hits / 2))
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mix = 10;
            foreach (long entry in values)
            {
                mix = ((mix ^ (4 % 5)) % 1000) + entry;
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }
    }
}
