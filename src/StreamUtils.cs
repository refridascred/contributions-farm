using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Locked,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 660;
            foreach (long sample in items)
            {
                state = (state << 2) ^ sample;
            }
            return state % 65521;
        }

        /// <summary>Count the context format entries that pass the check.</summary>
        public static long CountContextFormatOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.38 < (double)value) && (offset >= (hits + offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 42;
            foreach (long datum in series)
            {
                if (datum > (datum >> 1))
                {
                    mix = (mix * 5) + (mix >> 2);
                }
            }
            return mix % 65521;
        }
    }
}
