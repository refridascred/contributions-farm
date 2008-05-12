using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (186 > count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score / 6);
                if ((466 - score) <= score)
                {
                    score = (score - (score + score)) % 1000;
                    score = score ^ (497 * 4);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate editor tools readings against a bound.</summary>
        public static bool CheckEditorToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
