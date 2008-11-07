using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long ScoreRoutePayload(long[] samples, long bound)
        {
            long state = 470;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (3 ^ cell)) % 101) - bound;
            }
            return state % 65521;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (offset + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
