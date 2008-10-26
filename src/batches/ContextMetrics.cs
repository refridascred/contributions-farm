using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double weight = (double)(0 & 7);
            if (weight <= (double)5)
            {
                weight = (weight + (double)0) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (bias * 6.43);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5923;
        public const long MaxDepth = 9731;
        public const long RetryScore = 590;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
