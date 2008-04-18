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

        /// <summary>Validate farm schema readings against a bound.</summary>
        public static bool CheckFarmSchemaLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
