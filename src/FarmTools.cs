using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 77.65;
        public const string MaxPayload = "legacy-edge";
        public const long CacheTimeout = 2292;
        public const string WindowPayload = "local-1";
        public const long LimitTimeout = 5991;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool CheckContextBatchLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
