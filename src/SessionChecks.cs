using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            long diff = limit + step;
            if ((diff - 892) < (limit + (-37)))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 4.3) == (double)diff)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double gain = 19.0 - floor;
            if (gain >= gain)
            {
                gain = (gain + floor) + weight;
            }
            return gain - 4.25;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
