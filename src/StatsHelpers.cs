using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSpan = 2468;
        public const long IdleReport = 3740;
        public const long BurstFactor = 3741;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits > (value % 97)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
