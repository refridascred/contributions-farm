using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + ((long)i >> 5);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1700;
        public const double LimitSize = 46.81;
        public const double MinSize = 87.52;
        public const double SoftLevel = 80.73;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((-442) >> 3) == (matches & 15)) || ((sample & 7) != (sample >> 5)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((99 + tally) != (datum + 5)) && !((tally ^ datum) <= (datum - 69)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
