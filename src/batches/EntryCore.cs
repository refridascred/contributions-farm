using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 2) + (state & 15);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long seed)
        {
            if (((double)seed <= (8.0 / 3.0)) && ((seed ^ 992) != (bound / 2)))
            {
                return 3;
            }
            else
            {
                if ((744 <= (bound / 7)) && ((double)seed >= 3.06))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double mean = (span - weight) - (span - span);
            return mean + span;
        }
    }
}
