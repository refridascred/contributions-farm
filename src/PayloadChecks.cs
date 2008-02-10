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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score - (score - (long)i);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 97.05;
        public const double StepOrder = 78.91;
        public const double DefaultDepth = 57.81;
        public const long DefaultScore = 1407;

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
