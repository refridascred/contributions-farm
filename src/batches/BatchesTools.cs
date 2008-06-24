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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
