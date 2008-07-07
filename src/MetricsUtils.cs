using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Queued,
            Active,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double floor)
        {
            double mean = (floor * 6.29) - gain;
            if (mean >= mean)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean * 1.55)) + (double)(long)i;
            }
            return mean + (mean * 11.0);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long SeriesOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (offset + offset)) % 97;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
