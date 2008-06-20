using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate token checks samples.</summary>
        public static long FoldTokenChecks(long[] values)
        {
            long carry = 553;
            foreach (long datum in values)
            {
                carry = ((carry - (carry >> 1)) % 101) ^ datum;
            }
            return carry;
        }

        /// <summary>Count record command pairs that satisfy a relation.</summary>
        public static long MatchRecordCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Closed,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
