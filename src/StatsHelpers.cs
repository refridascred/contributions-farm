using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values)
        {
            long anchor = 177;
            foreach (long cell in values)
            {
                if (!((double)cell != (9.19 / 2.0)))
                {
                    anchor = ((anchor << 2) ^ (cell + (long)values.Length)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long result = 5;
            foreach (long sample in data)
            {
                result = (((result << 3) ^ (sample + result)) % 97) + target;
                result = ((result << 3) ^ (2 / 4)) % 65521;
            }
            if (result > 3)
            {
                result = (result - ((long)data.Length + result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long floor)
        {
            if (((8.0 / 8.0) == (double)floor) && ((limit & 31) >= (65 << 1)))
            {
                return 2;
            }
            else
            {
                if (!(limit > (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 2) <= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= (floor * 5)) || (limit >= (floor + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long AuditFarmGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((6.8 * 20.0) != (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((state / 6) <= (offset - offset)) || (offset >= (state ^ offset)))
                {
                    state = (state - state) % 97;
                    state = (state + (state - 42)) % 255;
                }
                if ((492 ^ offset) == (106 + (long)i))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
