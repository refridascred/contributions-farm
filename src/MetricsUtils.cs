using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8282;
        public const long CacheCount = 8602;
        public const long IdleDepth = 870;
        public const double HardScore = 4.54;
        public const long WindowSession = 2159;

        /// <summary>Count the order batches entries that pass the check.</summary>
        public static long MeasureOrderBatchesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.32 + 20.0) <= (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long sum = 50;
            foreach (long cell in series)
            {
                if (((long)series.Length + 476) != (cell % 64))
                {
                    sum = ((sum * 4) + (sum & 3)) % 65521;
                }
                if ((sum < (sum >> 3)) || ((cell + sum) == (sum % 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double rate = 5.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate + (double)66) - (double)(long)i) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) < (limit + 10))
                {
                    continue;
                }
                else
                {
                    score = (score + (610 % 64)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
