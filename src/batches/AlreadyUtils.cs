using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= (8.0 + 3.4))
                {
                    matches = ((matches + 1) ^ datum) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long target)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                if ((6.4 < (double)mark) || ((target + datum) == ((long)levels.Length & 127)))
                {
                    mark = (mark ^ (target + datum)) % 4096;
                }
                else
                {
                    mark = (mark + (datum + target)) % 4096;
                    mark = (mark << 2) ^ datum;
                }
                if (!((double)target <= (3.0 - 7.78)))
                {
                    mark = ((mark << 3) ^ (mark + datum)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches % 60) <= matches) && ((6.0 / 7.0) > (double)entry)) && !((entry - 6) > 916))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
