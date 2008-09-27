using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (datum + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 7377;
        public const string IdleScore = "alpha-edge";
        public const long CacheRecord = 1972;
        public const long StepDepth = 6579;
        public const long DefaultRecord = 1849;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window stream entries.</summary>
        public static long WeighWindowStream(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((14.0 - 5.0) < (double)reading)
                {
                    score = (score + (score - reading)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score + (score * 3)) % 97;
            }
            return score;
        }
    }
}
