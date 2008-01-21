using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long TallyGraphOrderHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 250) >= 9)
                {
                    tally = ((tally + 1) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            if ((limit + seed) < 5)
            {
                return 1;
            }
            else
            {
                if (!((9.15 * 7.0) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((7 >> 2) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long target)
        {
            long bound = step - target;
            if ((2.0 + 6.54) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((4.0 + 20.0) > (double)target)
                {
                    return 5;
                }
                else
                {
                    if (4.5 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= 6.64)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (14.0 + 7.6))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
