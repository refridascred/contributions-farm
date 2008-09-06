using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((double)matches == (7.5 / 6.0)) && ((matches / 9) <= sample))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 5500;
        public const long SoftTimeout = 349;
        public const string RetrySchema = "primary-v2";
        public const string BurstCount = "legacy-1";

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if ((double)datum >= (0.2 - 8.0))
                {
                    anchor = (anchor + (anchor << 1)) % 255;
                    anchor = (anchor - (datum + anchor)) % 255;
                    break;
                }
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Idle,
            Pending,
        }
    }
}
