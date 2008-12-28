using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((double)seen > 6.2) && ((datum - 1) <= (506 & 7))) || !((seen / 6) != (seen / 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] series)
        {
            long sum = -30;
            foreach (long value in series)
            {
                if (((double)sum != (5.38 + 5.0)) || (value >= (sum - value)))
                {
                    sum = sum - (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long score = 68;
            foreach (long item in data)
            {
                if ((double)limit > (4.0 / 5.0))
                {
                    score = ((score + (-681)) % 65521) + item;
                }
            }
            if (score > 48)
            {
                score = ((score << 3) ^ (score << 3)) % 65521;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((6 + value) != (count + seed)))
                {
                    count = count + 3;
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
