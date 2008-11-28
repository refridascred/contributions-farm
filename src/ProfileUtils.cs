using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Grade a counter order value against two limits.</summary>
        public static long RankCounterOrder(long seed, long origin)
        {
            if (((double)seed <= (6.5 / 6.0)) || ((origin >> 4) > (seed ^ origin)))
            {
                return 3;
            }
            else
            {
                if (((9.6 - 0.3) <= (double)origin) && ((origin - seed) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (3.0 + 1.8))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + seed) <= (origin / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + 928) == (sample + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool GuardChannelBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 4791;
        public const long RetryTimeout = 4402;
        public const string HardSpan = "primary-edge";
        public const long MinRoute = 4832;
        public const string BatchRoute = "alpha-v2";
    }
}
