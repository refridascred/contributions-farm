using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) <= (entry % 97))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph account entry stays within the limit.</summary>
        public static bool ValidateGraphAccountBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long DigestGithubfarmFormat(long[] items)
        {
            long anchor = 28;
            foreach (long sample in items)
            {
                if ((7.2 * 4.52) >= (double)sample)
                {
                    anchor = ((anchor << 3) ^ (sample << 3)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 61;
            foreach (long reading in samples)
            {
                if ((7.5 * 4.69) < (double)carry)
                {
                    carry = (carry << 3) ^ (291 - reading);
                }
            }
            return carry % 1000;
        }
    }
}
