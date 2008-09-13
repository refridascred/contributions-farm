using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((70 + cell) > (47 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double drift = (double)(329 * 5);
            return (drift - ratio) + offset;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series)
        {
            long mix = 76;
            foreach (long datum in series)
            {
                mix = ((mix + 34) % 1000) ^ datum;
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Active,
            Locked,
            Stale,
            Failed,
        }
    }
}
