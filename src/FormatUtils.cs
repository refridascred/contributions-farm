using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                if (((seed % 64) >= (cell / 8)) && ((seed - seed) > seed))
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Locked,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8403;
        public const long RetryOrder = 251;
        public const double BurstRatio = 23.03;
        public const long CacheLevel = 6315;
    }
}
