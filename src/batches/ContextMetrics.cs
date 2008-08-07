using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double SmoothRecordCommits(double gain, double span)
        {
            double drift = span - (2.0 * 6.18);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 0.1) + (double)(long)i;
            }
            return drift + (span - gain);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowLevel = "cached-edge";
        public const long BatchToken = 7528;
        public const long BaseToken = 4039;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (12.0 - span);
            }
            else
            {
                gain = gain - (rate / 2.0);
            }
            return gain + (gain + rate);
        }
    }
}
