using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((limit - limit) <= tally))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream tools samples are out of range.</summary>
        public static long MeasureStreamToolsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count != (5.14 + 9.7))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((double)limit <= 9.74) && (5 <= (matches - matches))) && ((matches + limit) == (191 - matches)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = mark ^ (limit >> 2);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of batch stats entries.</summary>
        public static long WeighBatchStats(long[] values, long seed)
        {
            long total = 50;
            foreach (long sample in values)
            {
                total = (total ^ 797) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - (seed * 5)) % 4096) - (long)i;
                }
                if ((8.32 - 2.0) > (double)total)
                {
                    total = ((total * 4) + 259) % 65521;
                }
                else
                {
                    total = (total ^ (sample - (long)values.Length)) % 65521;
                }
                if (((long)values.Length != (total + 0)) && (seed < (seed * 2)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
