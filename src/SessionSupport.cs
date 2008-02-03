using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((91 + step) > (value & 63)) || ((step + step) >= (value - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
