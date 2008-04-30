using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks order samples.</summary>
        public static long CombineChecksOrder(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((reading + anchor) != (653 + reading))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((40 % 2) == (reading + 25))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Pending,
            Locked,
        }
    }
}
