using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9681;
        public const long DefaultScore = 3048;
        public const long DefaultSize = 7326;
        public const long SoftSupport = 8154;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((49 & 7) < (offset + offset))
            {
                return 5;
            }
            else
            {
                if (((2.8 / 4.0) > (double)floor) && ((6.0 - 5.0) != (double)gap))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= 7.9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap >= (gap / 9)) || ((double)floor != (19.0 * 4.65)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
