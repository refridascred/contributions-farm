using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double ScaleNotesBatch(double bias, double bias2)
        {
            double ratio = 0.5 + 9.48;
            if (ratio >= (ratio * 3.6))
            {
                ratio = ratio + (0.52 / 9.0);
            }
            else
            {
                ratio = ratio + (bias / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias + bias2)) - (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
