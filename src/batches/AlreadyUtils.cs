using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double weight = (2.63 - ratio) - (9.6 * 15.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (ratio / 7.0)) + (double)(long)i) + floor;
            }
            return weight + 4.06;
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
