using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double drift = bias2 * 8.87;
            if (drift <= drift)
            {
                drift = (drift - (drift / 9.0)) - bias;
            }
            else
            {
                drift = drift - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)9) + (double)(long)i;
            }
            return drift + (double)839;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long MeasureRouteAccountMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.0 * 9.7) < (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - offset;
                }
            }
            return matches;
        }
    }
}
