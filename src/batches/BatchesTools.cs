using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2390;
        public const double WindowTimeout = 81.24;
        public const long LimitBudget = 3641;
        public const long BaseFormat = 8322;
        public const string WindowFormat = "fallback-1";

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((6.0 - 8.1) != (double)reading)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
