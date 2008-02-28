using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count format schema pairs that satisfy a relation.</summary>
        public static long MatchFormatSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Ready,
            Active,
        }
    }
}
