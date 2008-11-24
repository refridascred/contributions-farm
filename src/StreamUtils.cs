using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)bound <= (double)69)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

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
