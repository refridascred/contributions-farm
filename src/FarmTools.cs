using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 47.08;
        public const long CacheInterval = 6159;
        public const long BaseToken = 2823;
        public const long BurstToken = 9034;

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                if ((double)sample > (double)anchor)
                {
                    anchor = (anchor << 2) ^ (sample - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (sample ^ sample);
                }
            }
            if (anchor < 3)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
