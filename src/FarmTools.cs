using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long seed, long seed2)
        {
            if ((seed2 - seed) >= seed2)
            {
                return 7;
            }
            else
            {
                if (((seed2 + seed) >= (seed << 1)) && ((seed2 + seed) >= seed))
                {
                    return 0;
                }
                else
                {
                    if ((seed2 - 827) < seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + seed) >= (seed % 97)) || ((seed2 - seed2) >= (seed - seed2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i + (long)i)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheDepth = "latest-v2";
        public const string LimitScore = "strict-edge";
        public const long BurstAlready = 183;
    }
}
