using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "primary-edge";
        public const long BatchScore = 699;
        public const long IdleMetric = 9900;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph channel entries.</summary>
        public static long FoldGraphChannel(long[] samples, long step)
        {
            long acc = 14;
            foreach (long datum in samples)
            {
                acc = ((acc - (datum - datum)) % 4096) - step;
            }
            return acc;
        }
    }
}
