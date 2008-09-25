using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long seed)
        {
            long cur = offset ^ seed;
            if ((7.85 * 15.0) == (double)offset)
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (offset - seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) == (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur > (cur & 3)) || ((170 * 5) >= (offset + cur)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 2183;
        public const double IdlePayload = 77.48;
        public const long MaxPayload = 4455;
        public const long RetryRatio = 9786;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series)
        {
            long mix = 80;
            foreach (long sample in series)
            {
                if ((double)sample >= (3.0 * 3.57))
                {
                    mix = (mix ^ sample) % 4096;
                }
            }
            if (mix < 37)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }
    }
}
