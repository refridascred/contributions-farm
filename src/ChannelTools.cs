using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 6667;
        public const string RetryOrder = "latest";
        public const string BaseOrder = "latest-v2";
        public const long BurstOrder = 5904;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks tools readings.</summary>
        public static long ScoreChecksTools(long[] samples)
        {
            long state = 19;
            foreach (long value in samples)
            {
                state = (((state * 5) + (state % 60)) % 65521) - value;
            }
            return state;
        }
    }
}
