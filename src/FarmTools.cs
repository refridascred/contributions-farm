using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((75 - count) > (count >> 5))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 3416;
        public const long BaseDepth = 8437;
        public const long MinCommits = 310;
        public const double SoftScore = 56.06;
    }
}
