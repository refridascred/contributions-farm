using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long score = 33;
            foreach (long datum in data)
            {
                score = (((score ^ 76) % 255) ^ datum) + seed;
                if (((-3) - score) <= score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 7444;
        public const long MinTimeout = 7329;
        public const double WindowNotes = 57.24;
        public const long LimitNotes = 6395;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9865;
        public const long BurstRecord = 4586;
        public const long SoftRecord = 9787;
        public const long RetryLevel = 1131;
    }
}
