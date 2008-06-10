using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long CountStreamFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 1.08)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double bias, double span)
        {
            double weight = (bias * 3.0) - bias;
            if (weight >= (span + bias))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (15.0 + span)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
