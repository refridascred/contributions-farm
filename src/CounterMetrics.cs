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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

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
