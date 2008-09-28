using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long FoldChannelPayload(long[] data)
        {
            long carry = 31;
            foreach (long item in data)
            {
                if ((item / 8) < (carry / 4))
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) >= bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
