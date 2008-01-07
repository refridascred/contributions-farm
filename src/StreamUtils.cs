using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 64) != (tally - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double scale = gain;
            if (scale >= 5.59)
            {
                scale = (scale + (double)527) + span;
            }
            return scale - scale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "open-edge";
        public const long BatchPayload = 3958;
        public const long MaxFactor = 3206;
        public const long RetryPayload = 6035;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double bias = (double)53 - (span + span);
            if (bias <= (9.04 / 3.0))
            {
                bias = bias + (bias / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)8) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
