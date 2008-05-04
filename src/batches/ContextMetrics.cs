using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((5.18 * 12.0) > (6.0 / 6.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
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
