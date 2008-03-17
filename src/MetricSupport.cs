using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long CountStreamLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 5) != (value - 485))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (result ^ (result >> 4)) - item;
            }
            return result;
        }
    }
}
