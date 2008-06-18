using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double mean = (double)(9 * 5);
            if (mean <= (weight * 4.19))
            {
                mean = (mean - mean) - bias;
            }
            else
            {
                mean = mean - (mean / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)0) - (double)(long)i;
            }
            return mean + (mean * 5.1);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8943;
        public const long SoftGraph = 6181;
        public const long HardGraph = 4777;
        public const long BatchWidth = 5628;
        public const double StepDepth = 15.82;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
