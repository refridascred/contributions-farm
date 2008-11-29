using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((3.0 > (double)item) && ((double)limit <= (9.12 + 8.8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local";
        public const double WindowBatch = 47.48;
        public const long RetryBatch = 6635;
        public const double IdleCount = 26.58;
        public const long BatchFactor = 738;
    }
}
