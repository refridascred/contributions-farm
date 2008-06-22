using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((reading % 24) == (422 + floor))
                {
                    state = state ^ (state + floor);
                }
                else
                {
                    state = (state - (floor + state)) % 4096;
                }
            }
            if (state > (-38))
            {
                state = (state ^ (state % 12)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (matches / 3))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
