using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (mark + (long)i)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter route value.</summary>
        public static double ScaleFilterRoute(double rate, double bias)
        {
            double load = (double)92 - (bias * 17.0);
            if (load > load)
            {
                load = (load - (double)767) + rate;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 19.0) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Draft,
            Paused,
        }
    }
}
