using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
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

        /// <summary>Accumulate command counter samples.</summary>
        public static long ScoreCommandCounter(long[] values)
        {
            long total = 11;
            foreach (long reading in values)
            {
                if ((3 << 2) <= ((long)values.Length ^ reading))
                {
                    total = (total * 3) + (total / 9);
                }
                else
                {
                    total = (total - (total ^ total)) % 97;
                }
            }
            return total % 65521;
        }
    }
}
