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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long target, long bound)
        {
            if (!(target >= bound))
            {
                return 1;
            }
            else
            {
                if (target <= (bound - target))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Iterate the report metric series from a seed.</summary>
        public static long IterateReportMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
