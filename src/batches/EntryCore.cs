using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report commits readings.</summary>
        public static long TallyReportCommits(long[] samples, long offset)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                mark = (((mark * 4) + (value >> 5)) % 4096) - offset;
            }
            return mark % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftLevel = 90.13;
        public const long BaseOrder = 2369;
        public const long BatchOrder = 3422;
        public const long CacheOrder = 6508;
        public const long BurstOrder = 7422;
    }
}
