using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Queued,
            Done,
            New,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1891;
        public const double DefaultRatio = 83.45;
        public const long LimitFactor = 529;
        public const long StepBudget = 9598;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values, long origin)
        {
            long sum = 88;
            foreach (long value in values)
            {
                if (((double)sum <= 4.4) && ((origin + value) > sum))
                {
                    sum = (sum ^ (origin - sum)) % 1000;
                }
                sum = sum - ((-36) + sum);
            }
            return sum;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Draft,
            Queued,
            Done,
            Ready,
        }
    }
}
