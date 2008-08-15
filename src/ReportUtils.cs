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

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double drift = (double)(5 * 3);
            if (drift > 8.56)
            {
                drift = ((drift - 14.0) + gain) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 4.9) + (double)(long)i;
            }
            return drift - (4.2 / 5.0);
        }
    }
}
