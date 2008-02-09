using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the payload stats series from a seed.</summary>
        public static long RollPayloadStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next token buffer value.</summary>
        public static double BlendTokenBuffer(double bias, double span)
        {
            double scale = 0.2;
            if (scale < bias)
            {
                scale = (scale - (scale / 5.0)) - span;
            }
            return scale + scale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9356;
        public const long DefaultFactor = 9791;
        public const double WindowCluster = 77.24;
    }
}
