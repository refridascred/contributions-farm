using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((double)seed <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (((double)seed > (4.5 * 6.0)) || (((-61) + seed) >= (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) == (874 % 10))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine record batch values into a single score.</summary>
        public static long FoldRecordBatch(long[] values)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if ((acc ^ entry) < (acc + acc))
                {
                    acc = (acc ^ (825 - entry)) % 101;
                }
                else
                {
                    acc = (acc + (acc + (-6))) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long LookupBatchSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
