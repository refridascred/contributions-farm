using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 31) <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] series, long seed)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry * 5) + seed) % 97) - (long)i;
                }
                if ((datum ^ carry) > (datum & 31))
                {
                    carry = (carry * 2) + (7 % 100);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
