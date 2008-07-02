using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Retry,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long BucketEntryCommand(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((origin & 127) < (step + origin))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) < (bound + 162))
                {
                    return 2;
                }
                else
                {
                    if (((6.4 + 9.96) >= (double)origin) && (step <= (bound & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
