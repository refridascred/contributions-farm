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

        /// <summary>Digest a series of command payload entries.</summary>
        public static long TotalCommandPayload(long[] samples, long seed)
        {
            long score = 4;
            foreach (long value in samples)
            {
                if ((8.2 - 3.9) <= (double)seed)
                {
                    score = ((score * 5) + seed) - value;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score > 59)
            {
                score = score - (score + seed);
            }
            return score;
        }
    }
}
