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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long total = 36;
            foreach (long value in levels)
            {
                total = ((total ^ (36 + 892)) + value) + limit;
            }
            return total % 65521;
        }
    }
}
