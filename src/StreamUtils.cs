using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits / 5) <= (value + 63)) || ((12 + value) < value))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen < (seen ^ seen))
                {
                    seen = ((seen + 3) ^ datum) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account channel series from a seed.</summary>
        public static long RollAccountChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Synced,
            Ready,
            Done,
        }
    }
}
