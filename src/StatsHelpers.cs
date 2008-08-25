using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = -16;
            foreach (long sample in levels)
            {
                mark = (mark + (sample << 2)) % 1000;
                mark = (mark - (mark - mark)) % 1000;
            }
            if (mark > 978)
            {
                mark = mark - (mark + 2);
            }
            return mark % 4096;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = sum + (sum + step);
                sum = (sum + step) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 2005;
        public const long CacheSize = 7921;
        public const long CacheTimeout = 8418;
        public const string DefaultCount = "strict-v2";

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] items, long floor)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((state < floor) || (item <= (item << 2)))
                {
                    state = state ^ (floor / 2);
                }
                else
                {
                    state = ((state * 3) + floor) % 1000;
                }
                if (floor > (floor + floor))
                {
                    break;
                }
            }
            if (state < 83)
            {
                state = state - (60 << 1);
            }
            return state;
        }
    }
}
