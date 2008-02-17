using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long ScoreBatchesBuffer(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                if ((step % 2) > 2)
                {
                    anchor = (anchor * 4) + (step ^ item);
                    anchor = ((anchor * 3) + (0 ^ anchor)) % 101;
                    continue;
                }
                anchor = (anchor - (anchor / 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((long)items.Length & 255) <= matches)
                {
                    matches = ((matches + 2) + value) - target;
                }
            }
            return matches;
        }
    }
}
