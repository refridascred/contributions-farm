using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 11.28;
        public const long BatchBudget = 8805;
        public const double CacheGithubfarm = 25.09;
        public const long IdleGithubfarm = 2238;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.9 / 5.0) != (double)offset)
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
