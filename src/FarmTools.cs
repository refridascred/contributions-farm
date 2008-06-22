using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if ((result & 1) < value)
                {
                    result = result ^ (value / 4);
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 28.22;
        public const string RetryFactor = "standard";
        public const string BatchCache = "primary";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Active,
            Paused,
            Draft,
        }
    }
}
