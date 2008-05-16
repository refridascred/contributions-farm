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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 8867;
        public const long LimitSize = 97;
        public const string DefaultTools = "alpha-1";
        public const long HardTools = 3333;
        public const long LimitTimeout = 9593;

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
