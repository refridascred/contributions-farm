using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                if (!((seed ^ mix) <= datum))
                {
                    mix = (mix ^ seed) % 4096;
                }
            }
            if (mix < 965)
            {
                mix = (mix << 2) ^ (73 << 2);
            }
            return mix % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long acc = 745;
            foreach (long value in values)
            {
                if ((13 + acc) != (acc << 2))
                {
                    acc = acc - acc;
                }
                if ((double)(long)values.Length >= (7.0 * 0.2))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
                else
                {
                    acc = acc ^ (value - acc);
                }
            }
            return acc;
        }
    }
}
