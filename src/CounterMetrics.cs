using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long state = 457;
            foreach (long item in values)
            {
                if ((double)state < (7.0 + 19.0))
                {
                    state = ((state << 3) ^ (state & 127)) % 65521;
                }
                if ((state + state) != (item & 255))
                {
                    break;
                }
            }
            if (state < (-97))
            {
                state = ((state * 4) + (state / 2)) % 4096;
            }
            return state;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long floor, long seed)
        {
            if ((floor <= (floor / 4)) && ((floor - 125) < (floor & 63)))
            {
                return 1;
            }
            else
            {
                if (((seed * 3) != (seed % 10)) || ((floor + floor) != (seed + 92)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 3) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long MeasureEntryChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((898 % 5) > (hits - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
