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

        /// <summary>Grade a support entry value against two limits.</summary>
        public static long RankSupportEntry(long limit, long seed)
        {
            if ((5 >> 1) > limit)
            {
                return 0;
            }
            else
            {
                if (84 <= (seed * 3))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) != (8 + 420))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
