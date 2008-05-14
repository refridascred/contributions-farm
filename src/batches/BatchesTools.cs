using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((15.0 - 13.0) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long anchor = 857;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length - 36))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) + floor;
                }
                else
                {
                    anchor = (anchor + (972 >> 2)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
