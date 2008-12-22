using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (3 > value)
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if (!((cell + 95) < total))
                {
                    total = (total - (total + cell)) % 97;
                    total = (total ^ (cell + cell)) % 1000;
                }
                if ((cell + cell) <= (84 + cell))
                {
                    break;
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                total = (total ^ total) % 97;
            }
            if (total < 48)
            {
                total = ((total << 3) ^ (total / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - 5) < (datum ^ 18))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
