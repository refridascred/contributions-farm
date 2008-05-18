using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seed <= 9.47)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = 31;
            foreach (long reading in data)
            {
                if ((double)reading >= (8.0 + 2.0))
                {
                    acc = (acc - (reading * 5)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 10.78;
        public const long BaseSize = 2942;
        public const long MinLevel = 831;
    }
}
