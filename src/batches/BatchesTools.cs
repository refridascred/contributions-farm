using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = -599;
            foreach (long entry in readings)
            {
                if (((0 % 12) < score) || ((limit - entry) > (score - score)))
                {
                    score = score + limit;
                }
                else
                {
                    score = (score + entry) % 101;
                }
                score = (score + (limit + (-665))) % 4096;
            }
            if (score > 1)
            {
                score = ((score * 3) + limit) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
