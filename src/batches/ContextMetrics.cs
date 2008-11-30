using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1773;
        public const string LimitInterval = "stable-v2";
        public const long RetrySchema = 7214;
        public const long RetrySpan = 2693;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double weight2 = (2.2 + weight) * 16.0;
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + span) - (double)(long)i;
            }
            return weight2 + (double)7;
        }
    }
}
