using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5823;
        public const double RetryCount = 95.28;
        public const string LimitChannel = "cached-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 2) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Stale,
            Dropped,
        }
    }
}
