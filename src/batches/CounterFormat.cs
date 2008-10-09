using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long CountContributiChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length - step) < ((-2) & 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long diff = seed - offset;
            if ((seed + diff) < (701 >> 3))
            {
                return 4;
            }
            else
            {
                if ((3 + diff) < diff)
                {
                    return 1;
                }
                else
                {
                    if ((diff >> 4) > 962)
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
}
