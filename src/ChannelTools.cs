using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((116 ^ matches) >= matches)
                {
                    matches = ((matches + 3) + item) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
