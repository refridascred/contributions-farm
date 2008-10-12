using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4408;
        public const long StepSupport = 3046;
        public const long LimitFactor = 5798;
        public const long MinSupport = 5756;
    }
}
