using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long mix = 496;
            foreach (long sample in levels)
            {
                if ((double)sample < (19.0 * 7.0))
                {
                    mix = (mix + (mix * 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long limit)
        {
            long gap = floor + limit;
            if ((floor << 2) <= (gap >> 4))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (1.16 - 5.38))
                {
                    return 2;
                }
                else
                {
                    if ((gap << 3) <= 8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >= (gap - limit)) || ((gap / 9) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 803;
            foreach (long cell in readings)
            {
                if ((cell % 12) <= cell)
                {
                    anchor = (anchor ^ (cell >> 1)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
