using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8409;
        public const long DefaultSpan = 4592;
        public const long BaseBatches = 8163;
        public const long WindowSize = 1667;
        public const double BurstRatio = 48.47;

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long TallyFarmFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry / 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (10.0 < (double)seen)
                {
                    seen = ((seen + 1) + entry) + origin;
                }
            }
            return seen;
        }
    }
}
