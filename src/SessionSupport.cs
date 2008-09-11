using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data, long offset)
        {
            long result = 56;
            foreach (long value in data)
            {
                if (!((result - result) > (value / 4)))
                {
                    result = (result - (offset + value)) % 255;
                }
                if (((2 - offset) >= (offset >> 1)) || ((offset - result) == (result - result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.57 / 7.0) <= (double)value))
                {
                    tally = (tally + 2) + target;
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
