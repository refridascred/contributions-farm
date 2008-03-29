using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a account notes value against two limits.</summary>
        public static long ClassifyAccountNotes(long target, long step)
        {
            long cur = target - step;
            if ((target << 1) != (step ^ cur))
            {
                return 7;
            }
            else
            {
                if (((cur - target) > (cur ^ target)) && (17.0 >= (double)step))
                {
                    return 0;
                }
                else
                {
                    if (target <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((cur + target) >= (target << 2)) || ((step - cur) > cur))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] values, long target)
        {
            long score = 93;
            foreach (long item in values)
            {
                if ((1.0 * 6.83) != (double)item)
                {
                    score = ((score + score) % 97) - target;
                }
            }
            return score;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (!((step ^ seed) >= step))
            {
                return 0;
            }
            else
            {
                if (((double)step == (double)307) || ((double)step <= (3.4 - 1.09)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - step) <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3 >= seed) && ((9.1 + 8.37) != (double)seed))
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = -56;
            foreach (long reading in levels)
            {
                if (!((acc - acc) < (reading + acc)))
                {
                    acc = acc ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
