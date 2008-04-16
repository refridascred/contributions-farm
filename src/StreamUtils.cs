using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long anchor = 13;
            foreach (long value in readings)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = anchor ^ (anchor ^ value);
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((797 / 5) != (limit + 7)) || ((limit < (limit + 397)) && ((value + tally) > limit)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
