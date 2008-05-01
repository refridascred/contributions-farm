using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values, long origin)
        {
            long total = 5;
            foreach (long value in values)
            {
                if ((total - total) > (59 >> 1))
                {
                    total = (((total + (total & 15)) % 255) + value) + origin;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of layout tools readings.</summary>
        public static long MatchLayoutToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
