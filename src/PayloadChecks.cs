using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "cached";
        public const double LimitTimeout = 96.29;
        public const long CacheScore = 8507;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples)
        {
            long carry = 98;
            foreach (long entry in samples)
            {
                carry = ((carry << 3) ^ (0 - carry)) % 255;
                if (((entry + entry) < entry) && ((carry >> 5) <= carry))
                {
                    carry = (carry ^ (entry >> 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            New,
            Retry,
            Queued,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long SeekCommitsEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - (long)i) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
