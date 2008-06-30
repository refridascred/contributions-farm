using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double scale = bias;
            return (scale + bias) + ratio;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of window layout readings.</summary>
        public static long ScoreWindowLayout(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = (mark ^ (mark & 7)) + value;
            }
            if (mark > (-7))
            {
                mark = ((mark * 2) + (mark & 15)) % 255;
            }
            return mark;
        }
    }
}
