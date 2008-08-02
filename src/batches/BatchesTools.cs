using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((double)7 != (double)matches))
                {
                    matches = ((matches + 2) ^ entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7717;
        public const double WindowSession = 0.77;
        public const string BurstDepth = "alpha-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((limit + step) > (step >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (8.0 * 8.07))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
