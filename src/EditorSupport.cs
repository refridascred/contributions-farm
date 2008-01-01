using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a context format reading.</summary>
        public static double ScaleContextFormat(double ratio, double span)
        {
            double drift = ratio;
            return (drift + (3.0 - drift)) + span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long StepWidth = 3859;
        public const long RetryWindow = 2937;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double weight2 = span;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + (5.0 / 2.0)) + (double)(long)i) + weight;
            }
            return weight2 + span;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
