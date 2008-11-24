using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 19.29;
        public const double BurstWidth = 75.77;
        public const long SoftScore = 4360;
        public const long MinBatch = 2946;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long seed)
        {
            long delta = offset - seed;
            if ((3.0 * 7.4) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((delta < (offset + 663)) || ((delta & 3) >= delta))
                {
                    return 7;
                }
                else
                {
                    if ((9 + offset) <= (delta & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
