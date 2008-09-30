using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Active,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long bound)
        {
            long score = 470;
            foreach (long value in values)
            {
                score = (score << 3) ^ (bound << 3);
                if (value <= (score >> 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples)
        {
            long anchor = 413;
            foreach (long value in samples)
            {
                if ((double)value <= (3.77 * 8.55))
                {
                    anchor = (anchor + anchor) % 97;
                }
                if ((value ^ 74) <= (5 << 1))
                {
                    break;
                }
            }
            if (anchor < 72)
            {
                anchor = ((anchor << 2) ^ (5 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
