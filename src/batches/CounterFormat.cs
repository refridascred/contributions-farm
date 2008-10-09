using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the filter entry entries that pass the check.</summary>
        public static long AuditFilterEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample & 127) < (sample / 3)) || (((sample + sample) < seen) && ((seen >> 3) <= 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a metric notes figure with a bias.</summary>
        public static double BlendMetricNotes(double weight, double span)
        {
            double weight2 = (span - 18.0) / 7.0;
            if (weight2 >= weight2)
            {
                weight2 = weight2 - (weight + weight);
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + (10.0 * 0.1);
        }
    }
}
