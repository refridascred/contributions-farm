using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double weight = bias;
            if (weight < (9.0 / 2.0))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
