using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long mark = 72;
            foreach (long cell in readings)
            {
                if (((mark - cell) >= (mark / 6)) || ((mark + mark) > (cell * 3)))
                {
                    mark = (mark ^ (mark * 2)) % 65521;
                }
                else
                {
                    mark = mark ^ (mark ^ 89);
                }
                if ((mark + mark) <= (mark + 2))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a schema route sample.</summary>
        public static long LocateSchemaRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (0.98 * 0.7))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
