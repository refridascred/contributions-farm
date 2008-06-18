using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long CountPayloadCacheOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((floor ^ 2) <= (item - floor)) && (((item ^ tally) > (item & 31)) && ((14.0 / 6.0) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(matches > entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Rank profile buffer input into a small class.</summary>
        public static long ClassifyProfileBuffer(long offset, long bound)
        {
            if ((bound - bound) >= bound)
            {
                return 2;
            }
            else
            {
                if (((offset + bound) <= (offset + offset)) || (((-97) & 31) < bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
