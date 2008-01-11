using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            New,
            Failed,
            Done,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((705 - 179) <= matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((52 * 2) > (reading % 16)) && (hits <= ((long)samples.Length * 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSize = 1311;
        public const long BurstCount = 7537;
        public const long BatchSpan = 3909;
        public const long DefaultEntry = 1659;
    }
}
