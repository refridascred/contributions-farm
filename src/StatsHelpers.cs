using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count support checks pairs that satisfy a relation.</summary>
        public static long PairSupportChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine support farm values into a single score.</summary>
        public static long CombineSupportFarm(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark << 3) ^ value) % 1000) + (long)i;
                }
                if (((double)value <= (8.1 / 6.0)) || ((value >> 5) != (883 * 4)))
                {
                    mark = (mark + (value * 3)) % 1000;
                }
                if (value <= (value & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long FoldBufferBatches(long[] levels)
        {
            long acc = 80;
            foreach (long entry in levels)
            {
                if ((acc >> 5) == (acc / 8))
                {
                    acc = ((acc << 2) ^ (entry ^ entry)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 5) < (target - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
