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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

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
