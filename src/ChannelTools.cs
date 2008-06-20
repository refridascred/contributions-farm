using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double rate = (offset / 7.0) + (offset / 3.0);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)7) + (double)(long)i) - ratio;
            }
            return rate - rate;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
