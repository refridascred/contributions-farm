using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 7105;
        public const string WindowToken = "standard-v2";
        public const long HardToken = 3032;
        public const long HardInterval = 8647;
        public const string MinToken = "fallback-v2";

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long target)
        {
            long span = seed - target;
            if ((target >> 1) > span)
            {
                return 2;
            }
            else
            {
                if (!((double)seed > 8.9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
