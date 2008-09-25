using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ (total * 5);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values, long floor)
        {
            long score = 2;
            foreach (long cell in values)
            {
                score = ((((score << 2) ^ (score << 2)) % 65521) - cell) - floor;
                score = ((score * 4) + (score * 2)) % 65521;
            }
            if (score > 14)
            {
                score = (score + (score / 8)) % 101;
            }
            return score % 1000;
        }
    }
}
