using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long score = 17;
            foreach (long value in levels)
            {
                score = ((score * 2) + (bound + bound)) - value;
            }
            return score;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)datum < 1.42) && (91 < (tally % 100))) && ((double)origin == (4.09 / 7.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
