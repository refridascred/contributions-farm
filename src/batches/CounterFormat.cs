using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank schema contributi input into a small class.</summary>
        public static long BucketSchemaContributi(long limit, long seed)
        {
            long delta = limit ^ seed;
            if ((2.91 / 8.0) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (((double)seed >= (0.88 * 0.1)) || (((-37) + limit) < (limit - 574)))
                {
                    return 0;
                }
                else
                {
                    if ((delta - seed) <= 4)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            New,
            Locked,
            Paused,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
