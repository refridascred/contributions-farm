using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double drift = (double)(175 & 127);
            return (drift - scale) + offset;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long ScoreCommitsReport(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = ((anchor + (item << 3)) % 97) - floor;
            }
            if (anchor > 855)
            {
                anchor = (anchor + (anchor & 31)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double mean = scale;
            return (mean - mean) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9137;
        public const string BurstAlready = "alpha-v2";
        public const long MaxSize = 672;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits & 63) > (reading << 3)) && ((hits ^ hits) >= reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Closed,
            Pending,
            Draft,
        }
    }
}
