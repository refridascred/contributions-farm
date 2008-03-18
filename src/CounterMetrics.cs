using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((long)items.Length >= step) && ((hits ^ 2) <= (item & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (double)87)
            {
                weight2 = weight2 - (double)8;
            }
            else
            {
                weight2 = weight2 + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (double)8) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Count stats schema pairs that satisfy a relation.</summary>
        public static long OverlapStatsSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((34 << 2) > (654 ^ cell))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
