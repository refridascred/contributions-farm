using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double scale = (double)((-21) / 5);
            if (scale >= (scale + bias))
            {
                scale = (scale - scale) - weight;
            }
            return scale - scale;
        }
    }
}
