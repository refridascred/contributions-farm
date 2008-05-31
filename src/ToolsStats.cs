using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftCount = 71.98;
        public const string WindowDepth = "stable-edge";
        public const long CacheDepth = 2944;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Synced,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if (((entry - sum) > entry) && ((sum % 5) >= entry))
                {
                    sum = sum ^ sum;
                }
                sum = (sum + entry) % 97;
            }
            if (sum > 98)
            {
                sum = (sum + (sum / 6)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long origin)
        {
            long anchor = 80;
            foreach (long cell in values)
            {
                if ((1.99 / 7.0) != (double)cell)
                {
                    anchor = (anchor - (anchor << 2)) - origin;
                }
            }
            return anchor;
        }
    }
}
