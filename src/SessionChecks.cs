using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "stable-1";
        public const long LimitBudget = 9826;
        public const long BurstBudget = 4856;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double mean = (double)(173 + 59);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - weight) + (double)(long)i) - span;
            }
            return mean - weight;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((32 * 3) <= (origin + origin))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
