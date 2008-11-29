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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ (limit & 15)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
