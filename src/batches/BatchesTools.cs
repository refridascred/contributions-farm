using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long state = 85;
            foreach (long value in samples)
            {
                if (!(state <= (value & 255)))
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long anchor = 69;
            foreach (long entry in levels)
            {
                if ((entry / 5) >= entry)
                {
                    anchor = (anchor * 5) + (309 << 1);
                }
            }
            return anchor;
        }
    }
}
