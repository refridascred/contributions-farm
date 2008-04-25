using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double load = rate;
            if (load < (rate / 5.0))
            {
                load = load + rate;
            }
            else
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (rate * 3.0);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
