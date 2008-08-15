using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetrySpan = 56.17;
        public const string BatchFarm = "primary-1";
        public const long MaxFarm = 4557;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double drift = span;
            if (drift <= scale)
            {
                drift = drift - 7.7;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)0) + (double)(long)i;
            }
            return drift + (double)(-61);
        }

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] values, long target)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((9 * 4) >= (score ^ cell))
                {
                    score = score + (target & 3);
                }
            }
            if (score > 41)
            {
                score = ((score * 2) + (387 * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4.4 * 9.2) < (13.0 + 5.3))
                {
                    hits = ((hits + 3) ^ cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Retry,
            Queued,
            Active,
        }
    }
}
