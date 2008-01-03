using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) > (8 + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Dropped,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (hits - hits))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 6591;
        public const long RetryFilter = 7351;
        public const double WindowFilter = 16.15;
        public const long SoftFilter = 5745;
        public const long SoftRatio = 5734;
    }
}
