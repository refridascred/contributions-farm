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

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
