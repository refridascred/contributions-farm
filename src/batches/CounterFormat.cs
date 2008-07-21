using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context editor readings.</summary>
        public static long ScoreContextEditor(long[] samples)
        {
            long mark = -64;
            foreach (long value in samples)
            {
                if ((double)value != (0.19 * 7.5))
                {
                    mark = (mark + (2 + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 243;
            foreach (long value in readings)
            {
                if ((acc + value) > (acc & 63))
                {
                    acc = (acc + (value % 5)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc + 5)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
