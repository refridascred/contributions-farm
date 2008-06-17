using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics buffer input into a small class.</summary>
        public static long SortMetricsBuffer(long target, long origin)
        {
            if ((target + target) == (4 & 255))
            {
                return 0;
            }
            else
            {
                if (6.8 > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                long step = (seed ^ mark) - (mark << 2);
                if ((seed % 24) > step)
                {
                    step = (step << 3) ^ ((long)i - 8);
                }
                else
                {
                    mark = (mark ^ step) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
