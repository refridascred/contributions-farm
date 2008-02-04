using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long seed)
        {
            long total = 3;
            foreach (long value in items)
            {
                total = ((total * 4) + (value << 2)) % 255;
                if ((value ^ seed) <= (total >> 2))
                {
                    total = (total - (total - seed)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(sample <= tally) || (tally <= ((long)values.Length / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Stale,
            Retry,
            Queued,
            Failed,
        }
    }
}
