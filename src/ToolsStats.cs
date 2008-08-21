using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= (sample ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long limit)
        {
            long anchor = 94;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 4) + 331) % 4096) ^ (long)i) - limit;
                }
                anchor = (anchor ^ (datum ^ datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (1.1 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long offset2)
        {
            if ((offset2 ^ offset2) > offset)
            {
                return 6;
            }
            else
            {
                if ((offset2 * 5) != (offset & 127))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
