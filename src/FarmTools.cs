using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Done,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 43) == (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
