using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long AuditChecksCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) > 30)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((533 % 12) <= (state << 2))
                {
                    long step = (limit + state) * 5;
                    state = state + step;
                }
                state = (state ^ limit) % 4096;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
