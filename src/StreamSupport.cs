using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = 525;
            foreach (long value in items)
            {
                if (!(state <= (state << 3)))
                {
                    state = (state - (state - 647)) ^ value;
                }
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long total = 458;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ step) % 65521;
                total = (total ^ (item ^ step)) % 101;
                if (total < (item >> 3))
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (step >> 3);
                }
            }
            return total;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Failed,
            Done,
            Closed,
        }
    }
}
