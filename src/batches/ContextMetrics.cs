using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((target << 2) < (limit - target))
            {
                return 4;
            }
            else
            {
                if ((target - limit) >= (6 << 1))
                {
                    return 1;
                }
                else
                {
                    if (7.4 < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target << 2) <= (limit + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank farm profile input into a small class.</summary>
        public static long SortFarmProfile(long seed, long bound)
        {
            long edge = seed - bound;
            if (!((seed - bound) <= 37))
            {
                return 6;
            }
            else
            {
                if ((bound ^ bound) >= edge)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (18.0 / 2.0)) && ((bound << 2) >= (edge ^ 22)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound < (seed >> 2)))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSize = 82.91;
        public const double StepNotes = 76.05;
        public const long BurstNotes = 3458;
        public const long DefaultSpan = 3191;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                long prev = carry;
                if (!((double)prev == (double)seed))
                {
                    carry = (carry << 3) ^ (139 - prev);
                    break;
                }
                prev = prev ^ (long)i;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
