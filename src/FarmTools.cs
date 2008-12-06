using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 69.27;
        public const string BatchBudget = "stable-edge";
        public const long HardChecks = 1943;
        public const long DefaultChecks = 4964;
        public const string RetryChecks = "cached-v2";

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double drift = (double)(281 + 2);
            if (drift >= bias)
            {
                drift = (drift + (drift / 6.0)) - span;
            }
            else
            {
                drift = drift - (double)2;
            }
            return drift + bias;
        }
    }
}
