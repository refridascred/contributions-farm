using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LocateFarmFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 3969;
        public const double LimitWidth = 9.37;
        public const long IdleRatio = 1076;
        public const long BatchGithubfarm = 8102;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((12.0 - 7.75) != (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
