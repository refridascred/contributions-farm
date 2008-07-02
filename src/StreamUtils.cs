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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Idle,
            Queued,
            Closed,
            Dropped,
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

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long MatchEditorChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double bias = rate - (floor - rate);
            return bias + rate;
        }
    }
}
