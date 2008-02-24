using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((1 - hits) < (datum + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (mark ^ (cell - 56)) % 97;
                mark = mark - (2 + mark);
            }
            if (mark < 66)
            {
                mark = (mark * 5) + (mark << 1);
            }
            return mark;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((mark >> 5) != (mark + mark))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
