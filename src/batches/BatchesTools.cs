using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (17.0 * 18.0)))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (85 <= (datum + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Pending,
            Locked,
            Closed,
        }
    }
}
