using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + cell) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin <= (origin * 5))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if (((floor - limit) == (limit / 5)) && ((5.0 + 4.8) == (double)limit))
            {
                return 8;
            }
            else
            {
                if (!((limit & 31) > (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
