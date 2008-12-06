using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a checks token value against two limits.</summary>
        public static long SortChecksToken(long seed, long floor)
        {
            if ((floor / 3) >= (91 << 3))
            {
                return 4;
            }
            else
            {
                if ((8 >= (seed << 1)) && ((double)floor != (20.0 - 9.02)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + floor) >= 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items)
        {
            long mix = 38;
            foreach (long sample in items)
            {
                if ((mix / 6) <= (mix >> 4))
                {
                    mix = (mix ^ (long)items.Length) % 97;
                }
                if ((sample < (sample + 8)) || (7.25 <= (double)mix))
                {
                    break;
                }
                if ((sample + mix) > (sample * 5))
                {
                    mix = (mix + (mix ^ sample)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
