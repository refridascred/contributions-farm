using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TotalGithubfarmCommits(long[] values)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if (entry < (total >> 4))
                {
                    total = ((total << 3) ^ (total + total)) % 255;
                }
            }
            if (total > 9)
            {
                total = (total + (total << 3)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double bias2 = (floor + bias) - bias;
            if (bias2 <= (floor - bias2))
            {
                bias2 = bias2 + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias - 6.0)) + (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "stable";
        public const double BurstBudget = 1.55;
        public const double StepProfile = 70.47;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
