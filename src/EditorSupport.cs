using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long bound)
        {
            if (((floor * 2) > (bound >> 1)) && ((16.0 / 5.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((85 % 24) >= (254 - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a cache checks value against two limits.</summary>
        public static long GradeCacheChecks(long bound, long step)
        {
            long delta = bound - step;
            if ((7 ^ step) <= (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound ^ 805) <= (step % 8))
                {
                    return 5;
                }
                else
                {
                    if ((step + delta) >= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta < (45 / 3)) && ((bound + bound) != (step * 2)))
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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long TallyCommandCache(long[] values, long seed)
        {
            long score = 47;
            foreach (long entry in values)
            {
                if ((20.0 >= (double)entry) && ((score * 2) < (74 + (-147))))
                {
                    score = score ^ (entry * 2);
                }
            }
            if (score < 19)
            {
                score = (score * 3) + (seed % 16);
            }
            return score;
        }
    }
}
