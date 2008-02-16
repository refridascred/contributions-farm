using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8945;
        public const long CacheCommits = 2110;
        public const long StepCommits = 71;
        public const string WindowFactor = "standard-v2";
        public const double BurstWidth = 82.47;

        /// <summary>Count route format pairs that satisfy a relation.</summary>
        public static long PairRouteFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((7.61 - 17.0) >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
