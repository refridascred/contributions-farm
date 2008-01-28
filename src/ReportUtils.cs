using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first editor githubfarm entry that matches the target.</summary>
        public static long LocateEditorGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (origin > (34 + lane))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) >= (810 - origin))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 2) == (0 / 2)))
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

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Pending,
            New,
            Idle,
            Synced,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = weight + (bias + bias);
            }
            return weight - weight;
        }
    }
}
