using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= (double)1)
            {
                rate2 = (rate2 - (double)985) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 * 6.0)) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchLevel = 1472;
        public const long HardContributi = 6464;
        public const double WindowRatio = 52.02;
        public const long BurstRatio = 6474;
        public const long CacheTimeout = 8140;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits >= (3.0 * 1.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
