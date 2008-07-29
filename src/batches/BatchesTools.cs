using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long offset)
        {
            long mix = 940;
            foreach (long value in values)
            {
                mix = (((mix * 5) + (827 - mix)) % 255) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ offset) % 101) ^ (long)i;
                }
                mix = (mix * 2) + offset;
            }
            if (mix > 277)
            {
                mix = mix + (47 % 10);
            }
            return mix % 1000;
        }
    }
}
