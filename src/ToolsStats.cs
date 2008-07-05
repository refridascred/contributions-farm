using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            if ((4.9 - 10.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (!(5.0 < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (offset <= 472)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 2563;
        public const long MinSize = 1441;
        public const string IdleInterval = "local";
        public const double SoftToken = 13.84;
        public const long CacheToken = 1248;

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "legacy-v2";
        public const long MinDepth = 8433;
        public const long MinScore = 3355;
        public const long CacheFormat = 7757;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            New,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
