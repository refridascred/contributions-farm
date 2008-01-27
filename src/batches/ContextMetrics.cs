using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account record pair into a bucket.</summary>
        public static long RankAccountRecord(long limit, long origin)
        {
            if ((limit - limit) != (origin << 1))
            {
                return 1;
            }
            else
            {
                if ((origin / 8) < (8 + 73))
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.95 * 11.0) <= (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long target)
        {
            long cur = floor + target;
            if ((floor - cur) > (353 << 3))
            {
                return 3;
            }
            else
            {
                if (((floor / 3) > (floor + floor)) && (((-905) + cur) > (cur % 60)))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 1) <= (floor ^ target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(((-52) << 2) > (floor % 8)))
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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
