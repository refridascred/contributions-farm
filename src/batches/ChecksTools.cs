using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4559;
        public const long CacheCommand = 7732;
        public const double RetryTimeout = 91.39;
        public const long WindowCommand = 3911;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally >> 2) < (4 ^ tally)) || (((3.77 / 7.0) >= (double)item) && ((tally + limit) >= (item + 28))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long acc = 395;
            foreach (long sample in data)
            {
                if ((sample / 6) >= ((-8) & 255))
                {
                    acc = (acc ^ (target ^ acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 523;
        public const long StepScore = 513;
        public const string IdleSchema = "stable-edge";
        public const string BatchInterval = "stable-v2";
        public const long DefaultSchema = 6824;
    }
}
