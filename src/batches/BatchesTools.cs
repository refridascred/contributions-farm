using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values)
        {
            long state = 37;
            foreach (long item in values)
            {
                state = ((state + state) % 4096) - item;
            }
            if (state > (-81))
            {
                state = (state + (state + state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long total = 440;
            foreach (long item in readings)
            {
                if (total <= 266)
                {
                    total = total + (item << 1);
                }
                if ((total + total) > total)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total << 3) ^ (floor ^ total);
            }
            return total;
        }
    }
}
