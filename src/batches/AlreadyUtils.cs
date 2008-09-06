using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool GuardBatchesAlreadyRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum & 3) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long TotalCacheOrder(long[] samples)
        {
            long score = 588;
            foreach (long sample in samples)
            {
                if (score <= (sample * 2))
                {
                    score = (score + sample) % 255;
                }
                if ((18.0 + 1.76) > (double)sample)
                {
                    score = (score + (score ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Active,
            Queued,
            Idle,
        }
    }
}
