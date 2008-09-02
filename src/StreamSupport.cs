using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < (2.64 * 8.0))
            {
                ratio2 = ratio2 + (6.0 / 3.0);
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (double)250) + (double)(long)i;
            }
            return ratio2 - (floor - floor);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first filter command entry that matches the target.</summary>
        public static long LookupFilterCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
