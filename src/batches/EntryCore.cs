using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = 3.77;
            if (load <= (scale + 9.4))
            {
                load = (load + load) - span;
            }
            return load - (scale - scale);
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
