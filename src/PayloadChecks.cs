using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long step)
        {
            long delta = target - step;
            if ((double)target <= (3.9 - 6.8))
            {
                return 3;
            }
            else
            {
                if ((double)step > (double)2)
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (15.0 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta << 3) < (step * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long origin)
        {
            long state = -23;
            foreach (long entry in values)
            {
                if ((state % 8) <= (origin << 3))
                {
                    state = (state ^ (entry - state)) % 101;
                }
                else
                {
                    state = state - origin;
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchLevel = 8424;
        public const long IdleCache = 196;
        public const long BurstLevel = 5583;

        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long TallyEditorTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (3.71 + 8.38))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
