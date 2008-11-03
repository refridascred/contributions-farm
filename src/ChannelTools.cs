using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((bound - 5) < bound)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items, long seed)
        {
            long mark = 166;
            foreach (long entry in items)
            {
                if ((mark >> 1) <= (mark + 3))
                {
                    mark = (((mark * 2) + (seed % 24)) % 255) - entry;
                }
                if (((double)seed <= (7.5 - 11.0)) || ((mark + 85) < (1 + 743)))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
