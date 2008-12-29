using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits >= (double)(long)values.Length) || ((hits & 255) != (datum << 3)))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
