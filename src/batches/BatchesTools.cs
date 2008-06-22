using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((3 >> 2) >= (result / 3))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches >= (9.05 - 9.95))
                {
                    matches = ((matches + 2) ^ datum) - floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
