using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double weight = (double)((-354) + (-70));
            if (weight >= (offset * 12.0))
            {
                weight = weight - (offset + ratio);
            }
            return weight - (double)567;
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
