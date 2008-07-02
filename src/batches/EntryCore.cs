using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long limit, long bound)
        {
            long gap = limit + bound;
            if ((double)limit >= (18.0 - 2.99))
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((12.0 * 16.0) == (double)gap) || ((1 + gap) > (bound & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) == (gap + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "open";
        public const string LimitBatch = "cached";
        public const long LimitCount = 4601;
        public const long RetryBatch = 1337;

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
