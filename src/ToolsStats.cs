using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowFactor = 76.24;
        public const long MaxScore = 3640;
        public const string BaseInterval = "alpha-v2";
        public const double LimitWidth = 75.35;
        public const double MaxFactor = 79.52;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (anchor >> 5)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 43.15;
        public const long WindowBudget = 7076;
        public const long BaseDepth = 4913;
    }
}
