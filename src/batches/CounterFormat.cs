using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items, long origin)
        {
            long result = 717;
            foreach (long item in items)
            {
                if (((483 - item) == (2 - origin)) || ((13.0 / 5.0) > (double)87))
                {
                    result = (result << 2) ^ 472;
                }
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
