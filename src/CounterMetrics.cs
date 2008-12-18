using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool CheckSchemaAccountLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((4.17 - 2.83) != (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long score = 78;
            foreach (long cell in items)
            {
                score = (score - (score + score)) ^ cell;
                score = score ^ (floor + 629);
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (target <= (tally & 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
