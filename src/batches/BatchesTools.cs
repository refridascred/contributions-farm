using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor token readings.</summary>
        public static long TotalEditorToken(long[] data, long floor)
        {
            long mix = 760;
            foreach (long value in data)
            {
                mix = ((mix ^ ((-1) * 3)) - value) - floor;
            }
            if (mix > 606)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 1002;
        public const long IdleLayout = 8299;
        public const string SoftWidth = "latest-edge";

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long offset)
        {
            if ((offset & 127) >= bound)
            {
                return 7;
            }
            else
            {
                if (((949 + (-56)) <= offset) && ((offset % 97) >= 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
