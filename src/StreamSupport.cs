using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long TallyOrderRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)hits >= (double)reading) && ((5.21 * 2.0) <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) > (count + 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Idle,
            Dropped,
            Active,
            New,
        }
    }
}
