using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value + value) <= (hits & 255)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double ProjectCommitsGraph(double scale, double floor)
        {
            double scale2 = (double)7 / 3.0;
            return ((scale2 - 3.3) + scale) + floor;
        }
    }
}
