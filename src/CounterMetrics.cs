using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 5.33;
        public const long MinSpan = 6451;
        public const long MaxStats = 4660;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm commits entries that pass the check.</summary>
        public static long CountGithubfarmCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen - 58) > (seen & 127)) || ((reading <= (seen * 5)) || ((double)reading <= (5.98 * 3.18))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
