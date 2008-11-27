using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long step)
        {
            long score = -5;
            foreach (long reading in items)
            {
                if ((step * 5) <= (step >> 2))
                {
                    score = score ^ (step - 48);
                    break;
                }
                if ((reading + (long)items.Length) < 3)
                {
                    score = (score - reading) % 65521;
                }
                if ((step >> 1) < ((-23) << 3))
                {
                    break;
                }
            }
            return score;
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
