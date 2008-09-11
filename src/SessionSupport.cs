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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
