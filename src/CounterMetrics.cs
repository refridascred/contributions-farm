using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double ScaleEntryEditor(double bias, double span)
        {
            double drift = span + (span * 6.0);
            if (drift > (drift - drift))
            {
                drift = drift - bias;
            }
            return drift + (drift * 5.97);
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
