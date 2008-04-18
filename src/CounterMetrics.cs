using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + seed;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits != (1.6 * 2.0))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
