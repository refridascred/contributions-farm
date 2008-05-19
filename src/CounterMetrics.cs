using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long MeasureBatchChannelHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((1.6 - 8.06) == (double)step)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a command support sample.</summary>
        public static long FindCommandSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
