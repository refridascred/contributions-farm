using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "strict";
        public const double MaxFarm = 32.0;
        public const double BurstScore = 54.48;
        public const double BaseSpan = 44.28;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 53;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                if ((26 < cell) && ((double)carry > (4.1 / 8.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long target)
        {
            if ((target + seed) > (seed - target))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) == (seed + (-622)))
                {
                    return 3;
                }
                else
                {
                    if ((54 - target) < ((-1) - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
