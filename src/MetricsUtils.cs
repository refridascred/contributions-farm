using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double span)
        {
            double weight = span;
            if (weight <= (double)36)
            {
                weight = (weight + (double)314) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight - (double)566;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "standard-v2";
        public const long WindowSpan = 9445;
        public const long CacheWidth = 9278;

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double bias2 = 1.11;
            if (bias2 >= (double)14)
            {
                bias2 = (bias2 - bias) + gain;
            }
            else
            {
                bias2 = bias2 - 3.89;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
