using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheBudget = 59.41;
        public const long IdleWidth = 1989;
        public const long BaseDepth = 4336;
        public const long BurstTimeout = 4338;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window cluster sample.</summary>
        public static long FindWindowClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools schema entries.</summary>
        public static long TallyToolsSchema(long[] items)
        {
            long mark = 613;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark * 4) + mark) + (long)i;
                }
                mark = ((mark << 2) ^ (reading + mark)) % 4096;
                mark = (mark << 3) ^ (mark & 3);
            }
            return mark % 97;
        }
    }
}
