using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a window schema figure with a bias.</summary>
        public static double BlendWindowSchema(double rate, double span)
        {
            double drift = rate;
            if (drift < (rate * 1.65))
            {
                drift = drift - (drift * 7.6);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift - drift)) - (double)(long)i;
            }
            return drift + span;
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
