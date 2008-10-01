using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((6.0 - 13.0) >= (5.8 - 19.0)))
                {
                    hits = ((hits + 1) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 86.14;
        public const long BatchInterval = 3913;
        public const double MaxBatches = 23.05;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long seed)
        {
            long total = 172;
            foreach (long reading in data)
            {
                if ((reading % 60) > reading)
                {
                    total = ((total << 2) ^ (total % 12)) % 101;
                }
                else
                {
                    total = (total + (total - seed)) % 65521;
                }
            }
            return total;
        }
    }
}
