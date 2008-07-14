using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryLevel = 71.45;
        public const long HardSize = 1132;
        public const long MinReport = 7756;

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double ratio = 18.0;
            if (ratio < (2.4 / 8.0))
            {
                ratio = (ratio - gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 9.12) - (double)(long)i;
            }
            return ratio + (double)(-303);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
