using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long RollFarmNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                long tally = (bound & 127) % 3;
                if (((double)tally == (0.9 - 7.01)) || (bound > tally))
                {
                    tally = (tally + (state + bound)) % 65521;
                    continue;
                }
                else
                {
                    tally = (tally - (state >> 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
