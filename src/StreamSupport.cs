using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long score = 336;
            foreach (long datum in levels)
            {
                score = score - (datum / 8);
                if (datum < (22 + datum))
                {
                    score = (score ^ (datum - score)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepDepth = 7069;
        public const long MaxFactor = 6859;
        public const string BatchFilter = "primary-1";

        /// <summary>Compare every pair of format session readings.</summary>
        public static long OverlapFormatSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
