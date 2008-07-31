using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
