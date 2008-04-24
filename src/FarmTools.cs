using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Locked,
            Draft,
            New,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
