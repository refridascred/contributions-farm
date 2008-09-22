using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (anchor - 675) + reading;
            }
            if (anchor < 969)
            {
                anchor = (anchor - (40 >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm buffer entries.</summary>
        public static long TotalGithubfarmBuffer(long[] readings, long offset)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix << 3) ^ offset) ^ item;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
