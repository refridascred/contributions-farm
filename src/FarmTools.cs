using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (bias + bias2) / 3.0;
            if (weight < (bias / 2.0))
            {
                weight = weight + (double)(-925);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)8;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double bias2)
        {
            double scale = (bias2 + bias) / 6.0;
            if (scale > scale)
            {
                scale = scale - (double)100;
            }
            else
            {
                scale = scale + (scale * 9.07);
            }
            return scale + (double)51;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
