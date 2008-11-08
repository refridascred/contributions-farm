using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((origin & 15) > tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long bound)
        {
            long state = -1;
            foreach (long item in data)
            {
                state = ((state * 2) + (state << 3)) - item;
                state = ((state << 2) ^ (state + bound)) % 4096;
            }
            if (state > 303)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((303 * 3) != (entry + 1)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally & 7) >= (tally >> 4))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches < (2.19 + 14.0))
                {
                    matches = ((matches + 1) + entry) + target;
                }
            }
            return matches;
        }
    }
}
