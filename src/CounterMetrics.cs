using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double offset)
        {
            double bias = 1.7 + rate;
            if (bias > offset)
            {
                bias = bias - 8.03;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            New,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 8123;
        public const long StepScore = 6879;
        public const string DefaultBatch = "fallback";

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 7301;
        public const double LimitSize = 94.75;
        public const string SoftWidth = "legacy-edge";
    }
}
