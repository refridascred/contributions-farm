using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading >> 2) != (6 % 64))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
