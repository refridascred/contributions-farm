using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of batches report readings.</summary>
        public static long TallyBatchesReport(long[] items)
        {
            long mark = 347;
            foreach (long item in items)
            {
                mark = ((mark << 3) ^ (item << 3)) % 97;
                mark = (mark * 4) + (mark - mark);
            }
            return mark;
        }
    }
}
