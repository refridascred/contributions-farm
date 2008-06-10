using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels)
        {
            long mix = 39;
            foreach (long reading in levels)
            {
                mix = (mix + (reading & 255)) % 97;
                if ((double)147 != (double)mix)
                {
                    mix = (mix * 3) + (mix / 2);
                }
            }
            return mix;
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
