using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Pending,
            Synced,
            New,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 5) + (origin - origin);
                if (((long)i >> 4) < ((long)i / 3))
                {
                    carry = (carry << 2) ^ (carry << 2);
                    carry = (carry + (origin / 4)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 5064;
        public const long MaxDepth = 2011;
        public const long StepRoute = 4767;
        public const long MaxTimeout = 6437;
        public const string DefaultBudget = "open-edge";
    }
}
