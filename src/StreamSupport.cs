using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (scale + weight))
            {
                scale = scale + (weight * 2.9);
            }
            return scale - (weight - scale);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally < (18.0 * 6.17))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "alpha-1";
        public const string IdleFarm = "stable";
        public const long BaseTimeout = 6622;
    }
}
