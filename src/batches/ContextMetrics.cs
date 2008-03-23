using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((double)8 < (8.36 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((floor ^ floor) < (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long carry = 512;
            foreach (long entry in levels)
            {
                carry = ((carry * 4) + (carry / 3)) % 4096;
                if ((seed - seed) >= (carry - entry))
                {
                    carry = ((carry << 2) ^ (-69)) % 97;
                }
                else
                {
                    carry = (carry + (742 % 8)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (seed - carry);
            }
            return carry;
        }
    }
}
