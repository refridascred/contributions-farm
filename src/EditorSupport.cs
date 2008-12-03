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

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Queued,
            Dropped,
            Pending,
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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long origin)
        {
            long span = limit - origin;
            if ((2.3 / 9.0) != (double)span)
            {
                return 1;
            }
            else
            {
                if ((span - 360) >= (origin - origin))
                {
                    return 3;
                }
                else
                {
                    if (4.3 < (20.0 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin * 2) == (16 / 8))
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
    }
}
