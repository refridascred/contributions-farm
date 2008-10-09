using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long WeighSchemaFormat(long[] samples)
        {
            long result = 194;
            foreach (long value in samples)
            {
                result = result + (value - result);
                result = (result * 4) + (value ^ value);
            }
            return result % 65521;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score + (score + (long)i);
                score = ((score << 3) ^ ((long)i / 9)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
