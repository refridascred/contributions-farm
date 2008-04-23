using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-v2";
        public const long SoftSize = 9856;
        public const string LimitCache = "stable-edge";
        public const long StepSpan = 5407;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double weight2 = 0.77;
            if (weight2 <= (weight2 - 0.93))
            {
                weight2 = (weight2 + weight) - floor;
            }
            return weight2 + weight2;
        }
    }
}
