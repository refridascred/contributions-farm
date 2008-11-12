using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((limit % 64) != (seen - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long DigestStatsCounter(long[] series)
        {
            long sum = 18;
            foreach (long sample in series)
            {
                if ((sample - sum) <= (2 >> 4))
                {
                    sum = (sum + (2 + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
