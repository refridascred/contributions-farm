using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double ratio = (double)516 * 9.82;
            if (ratio >= weight)
            {
                ratio = (ratio - (weight / 2.0)) - span;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Paused,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double bias = rate - (floor - rate);
            return bias + rate;
        }
    }
}
