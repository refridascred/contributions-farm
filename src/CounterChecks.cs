using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next token route value from a seed.</summary>
        public static long StepTokenRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if (20.0 < (double)total)
                {
                    total = (total - (769 + seed)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Measure how many schema order samples are out of range.</summary>
        public static long CountSchemaOrderGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - step) > (hits & 255))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 92.07;
        public const double BurstCount = 10.87;
        public const long RetryScore = 9117;

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
