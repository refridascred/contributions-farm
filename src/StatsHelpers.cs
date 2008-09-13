using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double AdjustGraphFilter(double gain, double offset)
        {
            double gain2 = 6.8 + offset;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (double)19) + (double)(long)i;
            }
            return gain2 - (gain - offset);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 70;
            foreach (long value in series)
            {
                acc = ((acc * 4) + (value + 58)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
