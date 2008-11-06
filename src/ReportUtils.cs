using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long step)
        {
            long bound = seed ^ step;
            if ((step - 96) > step)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= (seed / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)16 < (double)step) || ((seed + seed) >= (step << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((bound << 2) <= result))
                {
                    result = (result ^ ((long)i - bound)) % 65521;
                }
                if (((result - bound) < (bound + result)) || ((78 & 255) < bound))
                {
                    result = ((result * 3) + ((long)i - bound)) % 97;
                    result = ((result << 2) ^ (97 << 1)) % 4096;
                }
                else
                {
                    result = (result - (bound ^ 39)) % 97;
                    result = (result + ((long)i >> 5)) % 101;
                }
                result = (result - (58 + result)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Dropped,
            Synced,
        }
    }
}
