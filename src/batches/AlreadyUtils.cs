using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Iterate the tools token series from a seed.</summary>
        public static long RollToolsToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ (acc - (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long delta = step + limit;
            if ((delta << 1) >= delta)
            {
                return 7;
            }
            else
            {
                if (8.5 >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 4) >= delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Stale,
            Ready,
        }
    }
}
