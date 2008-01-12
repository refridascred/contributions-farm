using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit cache account readings against a rule.</summary>
        public static long MeasureCacheAccountGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (952 < value)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
