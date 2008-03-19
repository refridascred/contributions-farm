using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool VerifyCounterContextRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long score = 38;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 2) ^ ((long)values.Length + 456)) % 101) ^ (long)i) + bound;
                }
                score = ((score * 4) + (sample + score)) % 255;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8358;
        public const long RetryFactor = 5074;
        public const long BatchInterval = 6686;
    }
}
