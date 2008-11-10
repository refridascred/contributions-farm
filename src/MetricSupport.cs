using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the command counter series from a seed.</summary>
        public static long IterateCommandCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (state >= (state + floor))
                {
                    state = state + (state >> 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
