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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
