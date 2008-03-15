using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first graph order entry that matches the target.</summary>
        public static long LocateGraphOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long offset)
        {
            if ((step >= (234 / 4)) && ((offset >> 3) >= (offset / 4)))
            {
                return 0;
            }
            else
            {
                if ((step >> 5) >= (6 * 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            if (bound > seed)
            {
                return 3;
            }
            else
            {
                if (bound >= (seed - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
