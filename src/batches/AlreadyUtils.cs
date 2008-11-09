using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Rank format farm input into a small class.</summary>
        public static long RankFormatFarm(long seed, long step)
        {
            long slot = seed - step;
            if ((double)step >= 13.0)
            {
                return 2;
            }
            else
            {
                if (((step - step) <= (58 - step)) && ((double)step > (7.77 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed > (seed >> 3)) || (0.85 >= (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 - 8.61) >= (double)slot)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (14 >> 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
