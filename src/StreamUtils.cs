using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long CountFilterChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "legacy-edge";
        public const double LimitScore = 34.14;
        public const string IdleStats = "alpha-1";

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (2.9 > (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
