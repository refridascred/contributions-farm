using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double weight = scale;
            if (weight < 2.93)
            {
                weight = (weight + (double)910) - span;
            }
            return weight + weight;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.88 > (double)item) && ((2 + item) > (tally - item)))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
