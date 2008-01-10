using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            long span = offset - limit;
            if ((span + 545) < (7 ^ 340))
            {
                return 6;
            }
            else
            {
                if (((34 - offset) == (limit + limit)) || (2 > (span + offset)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (value + 54))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long SeriesAccountMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((14.0 + 1.57) > (double)mark)
                {
                    mark = (mark - (mark + target)) % 4096;
                    mark = (mark - (target + target)) % 101;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinFactor = 8876;
        public const long HardProfile = 4948;
        public const long BurstSize = 4893;
    }
}
