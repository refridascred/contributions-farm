using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long state = 65;
            foreach (long datum in levels)
            {
                if ((datum - 311) >= state)
                {
                    state = (state * 2) + datum;
                }
            }
            if (state < 4)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long bound, long bound2)
        {
            long next = bound - bound2;
            if (!((next ^ next) != (bound - next)))
            {
                return 5;
            }
            else
            {
                if (!((bound2 * 4) != (next & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((double)next <= (double)bound2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 * 3) <= (next / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor < (floor - floor)) || ((sum / 9) != (803 ^ sum)))
                {
                    sum = (sum ^ (sum ^ sum)) % 1000;
                    sum = (sum ^ (6 ^ 16)) % 1000;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
