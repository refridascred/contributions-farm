using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long offset)
        {
            long anchor = 916;
            foreach (long item in data)
            {
                if ((double)offset >= (9.3 + 3.4))
                {
                    anchor = ((anchor - ((-82) - offset)) % 4096) + item;
                }
            }
            if (anchor < 74)
            {
                anchor = anchor + (9 - 55);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Done,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long bound)
        {
            long anchor = -61;
            foreach (long sample in levels)
            {
                if (((3.8 * 3.53) < (double)sample) || ((62 + anchor) > (anchor - 31)))
                {
                    anchor = (anchor ^ sample) - bound;
                }
                anchor = (anchor + 6) % 255;
                if ((anchor % 60) <= (sample / 2))
                {
                    anchor = (anchor - (sample >> 4)) % 4096;
                }
            }
            if (anchor > 37)
            {
                anchor = ((anchor << 3) ^ 797) % 101;
            }
            return anchor;
        }
    }
}
