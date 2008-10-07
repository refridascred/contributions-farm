using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels, long offset)
        {
            long score = -5;
            foreach (long reading in levels)
            {
                if ((score - score) <= score)
                {
                    score = ((score << 3) ^ (9 - reading)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (409 ^ offset)) % 4096;
                }
            }
            if (score > 2)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading <= (hits / 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double bias)
        {
            double drift = weight;
            if (drift >= bias)
            {
                drift = drift - (7.0 * 5.0);
            }
            return drift - (double)546;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) >= (303 * 2))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
