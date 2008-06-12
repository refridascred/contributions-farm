using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Draft,
            Closed,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstLevel = 8467;
        public const long CacheChannel = 8326;
        public const long StepBudget = 1071;
        public const double CacheInterval = 22.84;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
