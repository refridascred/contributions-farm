using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (gain / 4.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "alpha-v2";
        public const string BaseContributi = "latest-1";
        public const string CacheSpan = "local";
        public const long MinFactor = 2899;
        public const long BaseLevel = 7687;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score * 5) + (origin / 6);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (value & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
