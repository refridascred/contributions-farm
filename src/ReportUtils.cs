using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 58.65;
        public const long CacheScore = 9830;
        public const double MaxScore = 62.42;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long limit)
        {
            long sum = 899;
            foreach (long entry in samples)
            {
                sum = (sum << 2) ^ (entry * 2);
                if ((0.82 * 2.4) >= (double)entry)
                {
                    break;
                }
            }
            if (sum > 978)
            {
                sum = (sum * 2) + (limit + sum);
            }
            return sum;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long AuditRouteReportMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(datum < (datum + 8)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data, long offset)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                acc = acc - (reading * 4);
                acc = acc ^ (offset + offset);
                if (23 > (acc % 60))
                {
                    acc = (acc ^ (751 - acc)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
