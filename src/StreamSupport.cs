using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum >> 1) < (996 / 5))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
