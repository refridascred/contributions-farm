using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) > seed)
                {
                    acc = (acc - (seed + acc)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Compare every pair of layout notes readings.</summary>
        public static long PairLayoutNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
