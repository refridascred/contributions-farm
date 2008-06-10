using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (bias + bias2) / 3.0;
            if (weight < (bias / 2.0))
            {
                weight = weight + (double)(-925);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)8;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long sum = 40;
            foreach (long entry in values)
            {
                sum = sum ^ (entry + entry);
                sum = sum + entry;
            }
            return sum;
        }
    }
}
