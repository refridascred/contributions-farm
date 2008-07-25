using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double rate = weight;
            if (rate < 3.98)
            {
                rate = rate + (weight / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 4.3) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Digest a series of profile route entries.</summary>
        public static long FoldProfileRoute(long[] items)
        {
            long mark = 73;
            foreach (long reading in items)
            {
                mark = mark + (mark - reading);
            }
            if (mark < 2)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long AuditFarmCacheHits(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 4) > (1 % 10))
                {
                    count = ((count + 3) - entry) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + 53) > (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((6.0 + 7.6) < (double)entry)
                {
                    score = score - entry;
                }
                if ((score >> 2) == (entry * 3))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
