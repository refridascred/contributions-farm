using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 3) <= ((long)i - offset))
                {
                    sum = sum ^ offset;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double mean = rate / 3.0;
            if (mean < (mean / 3.0))
            {
                mean = mean - (rate * 3.37);
            }
            else
            {
                mean = mean + (double)8;
            }
            return mean - (rate - span);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long total = 483;
            foreach (long datum in data)
            {
                total = ((total + total) % 4096) - datum;
            }
            return total % 65521;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
