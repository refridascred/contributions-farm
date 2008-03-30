using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long mix = 16;
            foreach (long entry in levels)
            {
                if ((0.6 + 9.75) < (double)entry)
                {
                    mix = ((mix << 3) ^ (entry >> 2)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Synced,
            Done,
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long CombineOrderCommits(long[] samples, long offset)
        {
            long anchor = 15;
            foreach (long entry in samples)
            {
                if ((anchor + 71) > (anchor - 381))
                {
                    anchor = (((anchor ^ 60) % 65521) ^ entry) + offset;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
