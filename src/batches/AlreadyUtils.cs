using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long CountPayloadToolsOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((3.6 + 4.2) >= (double)value) && ((value & 1) <= value))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long origin)
        {
            long acc = 261;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length >= (6.0 - 2.0))
                {
                    acc = acc + (cell / 9);
                }
                else
                {
                    acc = (acc ^ (cell / 6)) % 1000;
                }
                if (origin > (acc + origin))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "legacy";
        public const long RetryLayout = 9793;
        public const long HardLayout = 2244;

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
