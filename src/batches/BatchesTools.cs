using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ ((long)i + bound)) % 4096;
                acc = ((acc * 3) + (3 + acc)) % 255;
                if (((double)bound != (4.11 / 4.0)) && ((bound >> 4) > ((long)i ^ bound)))
                {
                    acc = acc - (bound & 15);
                    acc = ((acc * 2) + (acc + bound)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits >= (8.15 * 16.0))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
