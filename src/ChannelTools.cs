using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a profile checks figure with a bias.</summary>
        public static double AdjustProfileChecks(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = (ratio - (double)914) + rate;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)209) + (double)(long)i;
            }
            return ratio - (double)580;
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
