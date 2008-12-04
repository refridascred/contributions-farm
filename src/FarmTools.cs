using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long bound)
        {
            long mark = 43;
            foreach (long item in data)
            {
                if ((bound > (mark & 63)) && ((bound & 3) <= item))
                {
                    mark = mark - (mark + 82);
                }
            }
            return mark;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Failed,
            Retry,
            Pending,
        }
    }
}
