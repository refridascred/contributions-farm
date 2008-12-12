using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count command metrics pairs that satisfy a relation.</summary>
        public static long PairCommandMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a batch counter counter forward.</summary>
        public static long StepBatchCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (long)i) % 65521;
                anchor = ((anchor * 4) + (origin ^ anchor)) % 4096;
                if ((origin * 2) <= (anchor / 9))
                {
                    anchor = (anchor ^ ((long)i * 5)) % 4096;
                    anchor = (anchor + ((long)i & 63)) % 101;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
