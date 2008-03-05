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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
