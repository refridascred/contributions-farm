using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (24 ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long floor)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                if (!(reading >= (floor & 31)))
                {
                    acc = (acc + (reading >> 3)) % 255;
                }
                if (!((floor * 2) >= floor))
                {
                    acc = ((acc << 2) ^ (floor << 2)) % 65521;
                }
            }
            if (acc > 363)
            {
                acc = ((acc << 2) ^ (floor - floor)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a tools format sample.</summary>
        public static long LookupToolsFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset >> 4) <= (65 - anchor)) || (offset <= (4 - offset)))
                {
                    anchor = ((anchor * 5) + ((long)i & 15)) % 97;
                }
                anchor = ((anchor << 2) ^ (offset * 4)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 5994;
        public const double MinScore = 98.74;
        public const string LimitMetrics = "open";
    }
}
