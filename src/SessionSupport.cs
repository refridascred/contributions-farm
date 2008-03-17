using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell <= (hits % 3)) || ((double)cell < (double)10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double ratio = (double)(0 - 94);
            if (ratio < span)
            {
                ratio = ratio - (span - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio - span)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
