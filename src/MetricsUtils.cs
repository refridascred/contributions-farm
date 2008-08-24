using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long CountSchemaClusterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (3.0 * 20.0))
                {
                    tally = ((tally + 3) - sample) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = offset / 3.0;
            if (load > (7.0 - offset))
            {
                load = load + (rate * 1.4);
            }
            return load + (double)356;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseSize = "standard-v2";
        public const long BaseRoute = 5751;
        public const long RetryRoute = 3719;
        public const long DefaultTimeout = 5847;
        public const long BaseTimeout = 8716;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (18.0 - 0.8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
