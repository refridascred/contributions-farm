using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 4.04;
        public const double BaseRatio = 73.86;
        public const string SoftDepth = "open-1";
        public const double RetryCommits = 30.99;
        public const long RetrySize = 9948;

        /// <summary>Project the next route channel value.</summary>
        public static double AdjustRouteChannel(double rate, double floor)
        {
            double bias = rate;
            if (bias > 8.88)
            {
                bias = (bias - (double)3) - floor;
            }
            return bias - 18.0;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Retry,
            Ready,
            Queued,
            Paused,
        }
    }
}
