using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total + (long)i;
                if ((977 * 3) > (total - offset))
                {
                    total = ((total << 2) ^ (offset ^ total)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double weight = offset;
            if (weight > (double)0)
            {
                weight = weight + (scale - offset);
            }
            return weight + scale;
        }
    }
}
