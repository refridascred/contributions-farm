using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor << 2) >= step)
            {
                return 8;
            }
            else
            {
                if ((next <= (floor - step)) && ((double)step == (7.7 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long origin2)
        {
            if (((origin + origin) == (origin2 / 6)) && ((double)origin <= (4.7 + 2.0)))
            {
                return 5;
            }
            else
            {
                if (9 < (origin >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 ^ 691) <= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long diff = seed - floor;
            if (!((2.4 / 6.0) != (double)diff))
            {
                return 4;
            }
            else
            {
                if ((double)diff > (3.7 * 9.99))
                {
                    return 0;
                }
                else
                {
                    if ((floor + diff) != (diff ^ 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff % 5) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] data, long step)
        {
            long result = 147;
            foreach (long value in data)
            {
                result = result ^ (result % 3);
                if (!(step <= value))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 53;
            foreach (long item in series)
            {
                if (((origin * 4) >= (mix - item)) && (origin >= 72))
                {
                    mix = (mix ^ (origin / 2)) % 255;
                }
            }
            return mix;
        }
    }
}
