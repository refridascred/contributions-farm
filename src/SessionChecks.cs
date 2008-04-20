using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7250;
        public const long DefaultQueue = 5911;
        public const long RetryQueue = 4619;
        public const long HardInterval = 5393;
        public const long BurstWidth = 9374;

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TotalStreamContext(long[] values, long limit)
        {
            long acc = -51;
            foreach (long entry in values)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 1000;
                acc = (acc - limit) % 65521;
                if (((double)acc <= (18.0 * 3.49)) && (7 > (limit + entry)))
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 4) + limit) % 65521;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((8.59 / 9.0) == (double)target))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long limit)
        {
            long mix = 193;
            foreach (long datum in levels)
            {
                mix = (mix << 2) ^ (limit * 4);
                if (!((datum * 5) > (255 & 15)))
                {
                    mix = (mix * 4) + datum;
                }
                else
                {
                    mix = (mix + (mix - datum)) % 4096;
                }
            }
            return mix;
        }
    }
}
