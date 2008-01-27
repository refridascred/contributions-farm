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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((item ^ hits) > (item << 2)) || ((item ^ (long)values.Length) < item)) || (((798 - item) == (item ^ item)) || ((item + item) <= (hits & 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3710;
        public const string DefaultRatio = "primary";
        public const double StepToken = 34.13;
        public const long MinWidth = 7381;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
