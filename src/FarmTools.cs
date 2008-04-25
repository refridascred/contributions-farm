using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
