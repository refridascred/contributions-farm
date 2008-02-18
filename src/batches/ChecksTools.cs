using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double load = (bias + bias) / 8.0;
            if (load > gain)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (load - gain);
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8743;
        public const double BatchEntry = 57.71;
        public const string WindowInterval = "open";

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double bias = (span * 3.0) / 2.0;
            if (bias < 8.0)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - 10.0;
        }
    }
}
