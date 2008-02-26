using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            New,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data)
        {
            long result = 659;
            foreach (long cell in data)
            {
                if (((result ^ (-3)) == (1 + result)) && ((3.0 * 0.99) != (double)result))
                {
                    result = (result << 2) ^ (cell + result);
                }
            }
            if (result < 3)
            {
                result = result + (result << 2);
            }
            return result % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 7) <= (datum + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
