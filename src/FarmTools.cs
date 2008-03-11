using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double bias)
        {
            double load = (double)208 - (weight * 2.37);
            return (load + load) + bias;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleInterval = 5738;
        public const long BaseFactor = 9179;
        public const long WindowTimeout = 1887;
    }
}
