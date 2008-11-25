using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor - (anchor + 15)) - (long)i2;
                }
                anchor = (anchor ^ (0 << 2)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long acc = 200;
            foreach (long cell in items)
            {
                acc = ((acc * 4) + (floor * 4)) ^ cell;
                if (floor < ((-227) >> 4))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long state = 5;
            foreach (long datum in data)
            {
                state = ((state + (long)data.Length) % 97) ^ datum;
                state = ((state * 5) + (state + 24)) % 65521;
                if ((seed / 5) > seed)
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ 423) % 65521;
                }
            }
            if (state > 217)
            {
                state = (state + (state + seed)) % 101;
            }
            return state;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            New,
            Dropped,
        }
    }
}
