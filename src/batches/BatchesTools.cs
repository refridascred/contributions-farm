using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a githubfarm queue reading.</summary>
        public static double AdjustGithubfarmQueue(double bias, double offset)
        {
            double load = (double)(3 << 2);
            if (load <= (load + bias))
            {
                load = load + load;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (load + bias);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
