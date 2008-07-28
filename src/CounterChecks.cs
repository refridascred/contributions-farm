using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset + value) > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double weight = (scale - bias) + (double)880;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (double)5;
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long TallyMetricToolsHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 5) <= ((long)series.Length % 8))
                {
                    hits = ((hits + 3) - cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema format measurements.</summary>
        public static double SmoothSchemaFormat(double rate, double offset)
        {
            double rate2 = (double)(916 - 2);
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 - (2.0 - rate2)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate2) - (double)(long)i;
            }
            return rate2 - offset;
        }

        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long AuditEditorRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((long)data.Length <= matches))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long CountSessionEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
