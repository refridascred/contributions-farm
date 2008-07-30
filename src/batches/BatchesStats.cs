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

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] items)
        {
            long mark = 78;
            foreach (long entry in items)
            {
                if (!((entry - 0) <= (mark + mark)))
                {
                    mark = (mark + (mark % 100)) % 1000;
                }
                mark = (mark + (entry + entry)) % 255;
            }
            if (mark < (-7))
            {
                mark = ((mark << 2) ^ 9) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
