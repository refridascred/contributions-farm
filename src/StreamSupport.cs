using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + 8.1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
