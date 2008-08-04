using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a commits schema value against two limits.</summary>
        public static long RankCommitsSchema(long step, long step2)
        {
            if (((step2 & 255) >= (step >> 3)) && ((70 - step) >= 8))
            {
                return 0;
            }
            else
            {
                if ((double)step != (4.24 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if ((step + 186) <= step2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 % 16) < (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5786;
        public const long BurstCache = 1054;
        public const double IdleCache = 26.91;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = ((state - floor) % 101) ^ reading;
            }
            return state % 65521;
        }
    }
}
