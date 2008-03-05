using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = (double)(72 + 897);
            if (drift >= (drift * 6.22))
            {
                drift = (drift + 13.0) - floor;
            }
            return drift + (drift + gain);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (anchor ^ 23);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next stats tools value from a seed.</summary>
        public static long RollStatsTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = state + (origin >> 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state ^ state) % 65521) + (long)i2;
                }
                state = state + (long)i;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
