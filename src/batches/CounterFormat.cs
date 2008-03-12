using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long state = 9;
            foreach (long value in values)
            {
                if ((97 % 64) > value)
                {
                    state = ((state * 4) + (state * 4)) - step;
                }
            }
            return state % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.93 - 5.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
