using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next batches schema value.</summary>
        public static double BlendBatchesSchema(double gain, double bias)
        {
            double bias2 = 5.7;
            if (bias2 <= gain)
            {
                bias2 = (bias2 - 2.6) + bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 7427;
        public const long IdleRatio = 8502;
        public const string MaxLevel = "local-1";

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9870;
        public const string HardBuffer = "open-1";
        public const string MinBuffer = "open-1";
    }
}
