using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long MeasureQueueMetricsGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(target <= (datum - hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long result = 2;
            foreach (long datum in items)
            {
                result = ((result * 5) + (1 ^ result)) + datum;
            }
            if (result > 403)
            {
                result = (result ^ (result / 3)) % 255;
            }
            return result % 1000;
        }
    }
}
