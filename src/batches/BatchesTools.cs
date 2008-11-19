using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Paused,
            Closed,
            Ready,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum * 4) < (target % 7)) && (((double)matches <= (2.6 + 4.6)) || ((matches ^ matches) > (7 + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Locked,
        }
    }
}
