using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - (long)series.Length) >= (3 << 3))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 1755;
        public const long StepLevel = 2141;
        public const long StepScore = 63;
        public const double CacheWidth = 56.59;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if (((result ^ result) != (result - reading)) || ((double)result != (6.0 - 9.68)))
                {
                    result = (result ^ (result + reading)) % 1000;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result < 9)
            {
                result = (result * 3) + result;
            }
            return result % 65521;
        }
    }
}
