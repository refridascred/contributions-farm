using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((0.61 - 12.0) >= (double)(long)samples.Length)
                {
                    hits = ((hits + 2) ^ reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSpan = 54.41;
        public const string BatchAlready = "standard-1";
        public const long DefaultTimeout = 8590;
        public const double LimitScore = 40.19;

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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
