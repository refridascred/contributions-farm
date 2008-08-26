using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a format layout reading.</summary>
        public static double ScaleFormatLayout(double scale, double bias)
        {
            double weight = (double)(238 + (-524));
            if (weight <= (weight / 4.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - 5.26;
            }
            return weight - scale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 8506;
        public const long StepRatio = 9412;
        public const string MinSpan = "open-1";
        public const string CacheMetrics = "standard-edge";
        public const string MinLevel = "legacy-1";

        /// <summary>Validate window entry readings against a bound.</summary>
        public static bool GuardWindowEntryLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
