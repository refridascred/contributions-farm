using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long mix = 35;
            foreach (long cell in values)
            {
                if (cell < 795)
                {
                    mix = ((mix ^ (-807)) % 4096) - limit;
                }
                if (!((double)cell > (0.19 * 9.2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((3.5 - 9.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
