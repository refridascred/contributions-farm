using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Locked,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)(-1) > (double)datum) && (((97 & 15) > (datum >> 2)) && ((count >> 3) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings, long limit)
        {
            long anchor = 221;
            foreach (long reading in readings)
            {
                if (((reading >> 2) != (anchor % 10)) || ((double)anchor != (5.3 - 7.65)))
                {
                    anchor = (anchor + (reading ^ 98)) + limit;
                }
            }
            return anchor;
        }
    }
}
