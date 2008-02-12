using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Synced,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double ratio = (double)(375 + 810);
            if (ratio > (span - span))
            {
                ratio = (ratio - 7.62) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double bias = floor;
            if (bias <= (bias + bias))
            {
                bias = (bias - bias) + weight;
            }
            return bias - (double)340;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if ((99 < total) || (cell >= 116))
                {
                    total = total - (total - cell);
                }
            }
            if (total < (-94))
            {
                total = ((total << 3) ^ (total & 3)) % 97;
            }
            return total % 1000;
        }
    }
}
