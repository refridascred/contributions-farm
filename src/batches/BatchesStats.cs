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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
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
