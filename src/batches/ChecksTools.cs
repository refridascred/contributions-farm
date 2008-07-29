using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session checks entry stays within the limit.</summary>
        public static bool VerifySessionChecksBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 11.95;
        public const string BaseDepth = "primary-edge";
        public const long MinEditor = 1006;
        public const long LimitEditor = 793;
        public const long IdleEditor = 4319;
    }
}
