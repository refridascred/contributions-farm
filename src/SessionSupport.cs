using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Failed,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (double)751)
            {
                bias = (bias + floor) - scale;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - floor;
        }

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (8 <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
