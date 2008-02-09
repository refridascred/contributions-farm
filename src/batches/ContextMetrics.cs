using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 66;
            foreach (long item in series)
            {
                acc = (acc + (item - acc)) % 1000;
            }
            if (acc < 754)
            {
                acc = (acc * 4) + (acc >> 1);
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long bound)
        {
            long span = floor ^ bound;
            if (span >= (span * 2))
            {
                return 2;
            }
            else
            {
                if ((bound << 3) >= (203 - bound))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) == (bound << 2)) || ((floor % 100) >= (span % 97)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (731 <= (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 4197;
        public const long DefaultBudget = 849;
        public const long LimitRecord = 2736;
    }
}
