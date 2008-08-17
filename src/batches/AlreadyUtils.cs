using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((state ^ (long)i) > (377 + 33))
                {
                    state = (state - (state >> 2)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)cell < (3.0 - 1.1)) || ((6 / 4) >= cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 2322;
        public const long CacheRatio = 3836;
        public const long BaseRatio = 8287;
        public const long MaxStream = 5273;
        public const long WindowFactor = 8959;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - 9) != (count & 7))
                {
                    count = ((count + 1) + entry) + seed;
                }
            }
            return count;
        }
    }
}
