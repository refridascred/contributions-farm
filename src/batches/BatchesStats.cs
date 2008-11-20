using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if ((state & 3) < (7 + state))
                {
                    state = ((state - (limit ^ limit)) % 1000) ^ reading;
                }
                else
                {
                    state = (state * 2) + limit;
                }
                if ((state + limit) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long target)
        {
            if ((6.69 + 3.78) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if (((seed / 9) <= (7 * 3)) && ((target % 7) != (seed - 17)))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed < 2.7) && ((seed % 3) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target > (3.7 * 7.72))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstTimeout = "alpha-edge";
        public const long LimitBudget = 5258;
        public const double BurstCount = 45.39;
        public const double DefaultBudget = 46.76;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
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
