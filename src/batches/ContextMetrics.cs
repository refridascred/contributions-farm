using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next account stats value.</summary>
        public static double AdjustAccountStats(double weight, double bias)
        {
            double weight2 = (double)(24 >> 1);
            for (int i = 0; i < 9; i++)
            {
                weight2 = ((weight2 - (weight - 13.0)) - (double)(long)i) - bias;
            }
            return weight2 - (double)(-976);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long TallyProfileOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length * 4) <= (562 << 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
