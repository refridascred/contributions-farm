using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowRatio = "staging-edge";
        public const string MinLayout = "strict-v2";
        public const long BaseLevel = 7673;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (double)7)
            {
                rate2 = (rate2 + 1.4) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)6;
        }

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double bias)
        {
            double scale = (double)9 * 1.0;
            if (scale >= (15.0 + bias))
            {
                scale = scale + (4.2 + rate);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - scale;
        }
    }
}
