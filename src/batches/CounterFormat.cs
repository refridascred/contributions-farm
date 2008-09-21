using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long offset)
        {
            long sum = 138;
            foreach (long item in items)
            {
                if ((offset >> 1) > item)
                {
                    sum = (sum * 4) + (item % 16);
                }
            }
            return sum % 1000;
        }
    }
}
