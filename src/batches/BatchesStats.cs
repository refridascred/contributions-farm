using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)865) + (double)(long)i) - bias;
            }
            return mean + weight;
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

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Paused,
            Ready,
            Pending,
        }
    }
}
