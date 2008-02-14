using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of counter cache entries.</summary>
        public static long TallyCounterCache(long[] samples)
        {
            long mix = 12;
            foreach (long value in samples)
            {
                if (((9.9 * 4.83) <= (double)mix) && ((value + mix) <= (value << 2)))
                {
                    mix = (mix << 3) ^ value;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((entry - anchor) >= anchor)
                {
                    anchor = (((anchor * 5) + (entry / 8)) % 97) + offset;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Failed,
            Done,
            Locked,
        }
    }
}
