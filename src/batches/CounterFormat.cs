using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a buffer cache reading.</summary>
        public static double ProjectBufferCache(double ratio, double floor)
        {
            double load = (double)(-62) - ratio;
            if (load < (floor / 7.0))
            {
                load = load + load;
            }
            else
            {
                load = load + (double)696;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
