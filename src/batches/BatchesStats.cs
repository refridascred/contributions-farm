using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item / 8) != (19 + seed))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 5131;
        public const long CacheLevel = 7687;
        public const long BatchInterval = 4513;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5223;
        public const long DefaultProfile = 6934;
        public const long HardProfile = 867;
        public const double RetryRatio = 97.69;
        public const long StepProfile = 6277;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
