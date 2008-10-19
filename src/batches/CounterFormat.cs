using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long mark = -35;
            foreach (long datum in items)
            {
                if (((double)85 != (double)mark) || ((long)items.Length > (867 << 1)))
                {
                    mark = (mark ^ mark) + datum;
                }
                if ((mark - seed) > (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 61)
            {
                mark = (mark - (seed ^ (long)items.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next batch payload value from a seed.</summary>
        public static long StepBatchPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if (acc <= (890 ^ target))
                {
                    continue;
                }
                else
                {
                    acc = (acc - ((long)i / 4)) % 97;
                    acc = ((acc << 2) ^ target) % 101;
                }
                if (!((double)(long)i >= (6.33 - 6.2)))
                {
                    acc = acc - (acc + 90);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
