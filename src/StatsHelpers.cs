using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((4.48 * 0.1) == (double)sum))
                {
                    sum = (sum - (0 >> 2)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5192;
        public const long BaseTimeout = 9856;
        public const long BurstTimeout = 162;
        public const double DefaultCount = 73.97;
        public const double BatchStats = 61.4;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed % 10) > (seed ^ seed))
                {
                    mix = (mix ^ (seed >> 4)) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
