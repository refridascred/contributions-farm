using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepBudget = 50.0;
        public const long LimitRatio = 9787;
        public const string LimitFormat = "fallback";
        public const double CacheFormat = 85.6;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Project the next already report value.</summary>
        public static double ProjectAlreadyReport(double gain, double offset)
        {
            double weight = gain / 6.0;
            if (weight <= (double)69)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
