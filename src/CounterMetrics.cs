using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Done,
            Queued,
            Paused,
        }
    }
}
