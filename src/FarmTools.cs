using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultFactor = 834;
        public const long StepSchema = 1720;
        public const long RetryFactor = 2983;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Draft,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
