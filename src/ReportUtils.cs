using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples, long limit)
        {
            long acc = 982;
            foreach (long datum in samples)
            {
                if (!(datum < (acc + 70)))
                {
                    acc = (acc ^ ((long)samples.Length << 3)) - limit;
                }
            }
            return acc;
        }

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

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = ((acc << 3) ^ (9 & 15)) - value;
            }
            if (acc < 48)
            {
                acc = ((acc * 2) + (acc ^ acc)) % 101;
            }
            return acc;
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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
