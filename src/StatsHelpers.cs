using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!(989 <= seed))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score << 2) ^ (score + 9)) % 4096;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
