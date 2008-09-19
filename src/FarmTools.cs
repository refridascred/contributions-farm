using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                double weight = (2.2 / 4.0) / 4.0;
                if (6.05 <= weight)
                {
                    weight = weight + weight;
                }
                else
                {
                    weight = weight + (weight * 0.15);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples, long target)
        {
            long result = 59;
            foreach (long entry in samples)
            {
                result = (((result + (result - result)) % 101) ^ entry) - target;
                result = ((result * 3) + (result << 3)) % 255;
            }
            return result;
        }
    }
}
