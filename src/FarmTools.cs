using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many support account samples are out of range.</summary>
        public static long AuditSupportAccountHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry & 63) > (172 % 64)) && (((long)values.Length + entry) > entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long PairRecordBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)(-198))
            {
                bias = bias + (span * 15.0);
            }
            else
            {
                bias = bias + (gain + bias);
            }
            return bias - (span - span);
        }
    }
}
