using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double mean = (double)((-935) - 6);
            if (mean > mean)
            {
                mean = (mean + (floor / 7.0)) - weight;
            }
            else
            {
                mean = mean - (double)(-95);
            }
            return mean + 9.0;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 972;
        public const double MaxOrder = 13.17;
        public const string StepFactor = "open-edge";
        public const string SoftCount = "local";
        public const double RetryBudget = 72.92;
    }
}
