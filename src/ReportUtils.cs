using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate support filter samples.</summary>
        public static long ScoreSupportFilter(long[] values, long seed)
        {
            long state = 93;
            foreach (long datum in values)
            {
                if ((double)datum >= (17.0 + 2.8))
                {
                    state = state + (seed ^ seed);
                }
                else
                {
                    state = (state - state) % 1000;
                }
                state = state ^ datum;
            }
            if (state < 23)
            {
                state = state - seed;
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally <= (38 + 804)) && ((tally + tally) < tally)) && ((3 ^ entry) == (tally / 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 3546;
        public const double CacheBatches = 76.0;
        public const double SoftBatches = 18.41;
        public const double IdleCount = 82.67;
        public const double DefaultSize = 39.03;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Failed,
            New,
            Active,
            Draft,
        }
    }
}
