using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long step)
        {
            long sum = 586;
            foreach (long item in items)
            {
                if (!((1.14 + 1.4) <= (double)step))
                {
                    sum = ((sum << 2) ^ (item + item)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 5724;
        public const string BurstTools = "strict-edge";
        public const long CacheTools = 9271;
        public const long RetryTools = 1697;
        public const double WindowWidth = 72.33;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((floor + floor) >= (floor - 48))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
