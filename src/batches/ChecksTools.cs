using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window route entries that pass the check.</summary>
        public static long TallyWindowRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value << 2) <= (84 % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window metric sample.</summary>
        public static long FindWindowMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((double)seed <= 9.9)
                {
                    break;
                }
                sum = (sum - (sum - seed)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
