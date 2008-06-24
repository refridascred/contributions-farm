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

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 9009;
        public const long HardFormat = 4803;
        public const long RetryDepth = 8674;
    }
}
