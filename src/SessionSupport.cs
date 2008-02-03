using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches + matches) < value) || (17.0 >= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) > offset)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
