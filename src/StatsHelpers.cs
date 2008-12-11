using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] values)
        {
            long score = -3;
            foreach (long sample in values)
            {
                if ((((long)values.Length % 5) > (sample & 7)) && ((score - 551) > score))
                {
                    score = ((score * 5) + (long)values.Length) % 101;
                }
                else
                {
                    score = (score + (sample - sample)) % 101;
                }
            }
            if (score < 0)
            {
                score = score - (score % 2);
            }
            return score;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long BucketCounterProfile(long offset, long floor)
        {
            long delta = offset + floor;
            if (offset < (352 + delta))
            {
                return 8;
            }
            else
            {
                if (((8.9 + 15.0) > (double)delta) || (offset > (floor / 9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long bound)
        {
            long total = 95;
            foreach (long cell in readings)
            {
                total = (((total << 2) ^ (cell % 3)) % 65521) - bound;
            }
            return total % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8559;
        public const long WindowEntry = 9907;
        public const string BurstSpan = "primary-1";
        public const string RetryEntry = "staging-v2";
    }
}
