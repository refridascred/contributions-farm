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

        /// <summary>Roll a checks farm counter forward.</summary>
        public static long RollChecksFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 3) ^ (mark ^ limit)) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
