using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 1722;
        public const long SoftMetrics = 5394;
        public const string MaxMetrics = "local-v2";
        public const long CacheMetrics = 1829;
        public const long DefaultCount = 3961;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long TallySchemaLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 3) <= (-4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (18 >= (seed + seed))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long offset)
        {
            long mix = 3;
            foreach (long reading in values)
            {
                mix = ((mix ^ (reading % 16)) % 97) + offset;
            }
            if (mix > 119)
            {
                mix = ((mix << 3) ^ (mix / 2)) % 4096;
            }
            return mix;
        }
    }
}
