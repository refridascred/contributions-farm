using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((double)20 == (double)floor) && (mix <= (mix << 1)))
                {
                    mix = (mix + ((long)i - 848)) % 97;
                    mix = (mix * 4) + floor;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long target)
        {
            long cur = offset + target;
            if (!((offset / 3) >= (target + offset)))
            {
                return 6;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((cur * 3) != (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)cur <= (6.5 / 7.0)) || ((double)cur == (8.0 * 7.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }
    }
}
