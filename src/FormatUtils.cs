using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 6803;
        public const double HardFactor = 72.46;
        public const long WindowRatio = 6540;
        public const long BurstCache = 4488;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Retry,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Rank profile route input into a small class.</summary>
        public static long BucketProfileRoute(long step, long target)
        {
            long diff = step - target;
            if (diff < (diff & 31))
            {
                return 0;
            }
            else
            {
                if ((double)diff > (0.01 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 2) <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff >= (diff + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long TallyOrderCounterMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (19.0 <= (double)sample)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((floor ^ floor) < (2 / 6)) && (((-68) + step) <= floor))
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
