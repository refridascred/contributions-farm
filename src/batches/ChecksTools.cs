using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double load = gain;
            if (load < span)
            {
                load = load - gain;
            }
            else
            {
                load = load + (double)80;
            }
            return load + load;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long BurstCount = 125;
        public const long DefaultContext = 3678;
        public const double BaseSpan = 16.6;
    }
}
