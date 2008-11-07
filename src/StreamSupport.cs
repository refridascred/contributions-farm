using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state - (origin % 60);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
