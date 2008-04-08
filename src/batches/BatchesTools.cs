using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6576;
        public const long IdleEditor = 3496;
        public const string WindowEditor = "staging-edge";

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 782;
        public const long WindowAccount = 7567;
        public const long RetryBudget = 2369;
    }
}
