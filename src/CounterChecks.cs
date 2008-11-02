using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) < entry)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account schema series from a seed.</summary>
        public static long SeriesAccountSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSize = "latest-edge";
        public const long RetryWidth = 5517;
        public const long WindowToken = 3934;
        public const long HardBudget = 92;
        public const double MinToken = 45.66;

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
