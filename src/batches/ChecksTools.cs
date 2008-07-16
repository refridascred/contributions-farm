using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Project the next contributi metric value.</summary>
        public static double AdjustContributiMetric(double weight, double floor)
        {
            double drift = (weight / 7.0) - 0.5;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (floor / 3.0);
        }
    }
}
