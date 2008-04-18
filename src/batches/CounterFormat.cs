using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Locked,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Active,
            Synced,
            Ready,
            New,
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool VerifyRouteContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
