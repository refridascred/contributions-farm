using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data, long origin)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (sum % 12)) % 97;
                if (((sample + sample) >= sample) || ((origin >> 4) != (0 ^ sample)))
                {
                    sum = sum - (origin % 8);
                }
                else
                {
                    sum = (sum + sample) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((7.79 * 18.0) < (double)step) && (sample < (step - step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((2.55 / 3.0) != (double)seen) || ((double)seen < (0.01 + 5.3)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
