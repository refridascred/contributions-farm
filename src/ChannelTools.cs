using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double gain = (bias + ratio) * 3.65;
            if (gain < (bias - 19.0))
            {
                gain = gain + (double)8;
            }
            return gain + ratio;
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
