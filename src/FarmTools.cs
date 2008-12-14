using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the stream graph series from a seed.</summary>
        public static long StepStreamGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state + (bound << 2)) % 101;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
