using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of token contributi readings.</summary>
        public static long TotalTokenContributi(long[] items, long bound)
        {
            long state = 812;
            foreach (long item in items)
            {
                if ((((long)items.Length & 127) <= (state << 3)) && ((765 & 31) > state))
                {
                    state = state - (bound & 63);
                    continue;
                }
                if ((double)state != (9.0 * 1.0))
                {
                    state = ((state << 3) ^ (item - 338)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
