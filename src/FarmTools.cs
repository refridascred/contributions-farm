using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ datum) != (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next order counter value.</summary>
        public static double BlendOrderCounter(double weight, double floor)
        {
            double scale = 4.65 * 3.4;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + weight) - (double)(long)i) - floor;
            }
            return scale - (2.14 - 0.2);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
