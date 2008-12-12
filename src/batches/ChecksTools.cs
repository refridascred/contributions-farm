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

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8708;
        public const long BatchTimeout = 2189;
        public const long MaxCache = 8995;
        public const long StepInterval = 1136;
        public const long BurstCache = 6564;
    }
}
