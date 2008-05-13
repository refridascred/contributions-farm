using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                mark = mark ^ (offset + reading);
            }
            if (mark < 49)
            {
                mark = mark ^ (398 >> 5);
            }
            return mark;
        }

        /// <summary>Derive the next cache commits value from a seed.</summary>
        public static long IterateCacheCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every already token entry stays within the limit.</summary>
        public static bool ValidateAlreadyTokenLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum * 3) + (sum + (-52))) % 4096) ^ sample;
            }
            return sum % 4096;
        }
    }
}
