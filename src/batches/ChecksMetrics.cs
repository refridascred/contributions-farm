using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = -28;
            foreach (long item in readings)
            {
                score = ((score ^ (score - 43)) % 65521) ^ item;
            }
            return score % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((0.1 * 4.68) >= (double)sample) || ((double)sample != (3.7 / 6.0))) && (matches <= (33 + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter token entry stays within the limit.</summary>
        public static bool GuardFilterTokenBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long anchor = 611;
            foreach (long reading in series)
            {
                anchor = ((anchor ^ (reading / 5)) % 255) - floor;
            }
            return anchor;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 602;
            foreach (long item in data)
            {
                total = total + item;
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (6 >> 2)) % 97;
            }
            return total;
        }
    }
}
