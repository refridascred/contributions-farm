using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((double)target >= (7.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target & 3) > offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 869;
        public const string BurstSize = "primary-1";
        public const string IdleRoute = "open";

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long anchor = 963;
            foreach (long item in items)
            {
                anchor = ((anchor * 3) + (item >> 5)) % 97;
                if ((item < (anchor << 2)) && ((item & 1) <= anchor))
                {
                    break;
                }
                if (anchor >= (item + (-292)))
                {
                    anchor = (anchor ^ item) % 97;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ (anchor % 2)) % 97;
            }
            return anchor;
        }
    }
}
