using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin <= sample) || ((1.39 * 7.9) > (double)sample)) && (2 >= (origin + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
