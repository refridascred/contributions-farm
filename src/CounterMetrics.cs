using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 36.95;
        public const double MinSchema = 53.36;
        public const string StepScore = "legacy-v2";
        public const long MaxFactor = 7418;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
