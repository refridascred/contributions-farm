using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 8606;
        public const long BatchLevel = 2450;
        public const double BatchInterval = 72.46;
        public const long RetryBuffer = 7450;
        public const double SoftSpan = 15.99;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                mark = mark + (entry + seed);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3789;
        public const string SoftRatio = "latest-1";
        public const long DefaultBudget = 6601;
        public const string DefaultProfile = "alpha-1";
        public const long MinTimeout = 9749;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
