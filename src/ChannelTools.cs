using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long seed)
        {
            long delta = floor + seed;
            if (delta <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 - seed))
                {
                    return 3;
                }
                else
                {
                    if (7 > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)seed <= (6.63 + 2.9))
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3813;
        public const long BatchTimeout = 2381;
        public const string BatchNotes = "open-edge";
    }
}
