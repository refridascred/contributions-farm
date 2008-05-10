using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches batch entries that pass the check.</summary>
        public static long AuditBatchesBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((-33) <= (count - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches metric value from a seed.</summary>
        public static long SeriesBatchesMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            long lane = offset + offset2;
            if (((lane << 1) == (offset2 >> 1)) || ((lane >> 1) != (lane + offset)))
            {
                return 5;
            }
            else
            {
                if (!((double)lane <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long OverlapAlreadyMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i & 31) > 5)
                {
                    total = total - (total / 4);
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                if ((8.83 / 4.0) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    total = total - (step * 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
