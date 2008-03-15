using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a commits command reading by value.</summary>
        public static long LocateCommitsCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long bound, long limit)
        {
            long slot = bound - limit;
            if ((bound + (-696)) != (slot + limit))
            {
                return 4;
            }
            else
            {
                if (45 >= (slot * 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 2257;
        public const long BaseRatio = 7886;
        public const long BaseTools = 149;
        public const long LimitLevel = 4441;
        public const long RetryDepth = 8000;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Paused,
            Stale,
        }
    }
}
