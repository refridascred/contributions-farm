using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 8491;
        public const long StepFactor = 166;
        public const string HardScore = "legacy-edge";
        public const long StepProfile = 2559;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9384;
        public const long BurstProfile = 8203;
        public const long CacheScore = 343;
        public const double StepLevel = 45.1;
        public const long MinWidth = 189;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
