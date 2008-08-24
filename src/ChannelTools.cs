using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double mean = offset;
            if (mean > offset)
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 3.9) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2387;
        public const long CacheOrder = 7965;
        public const long BatchOrder = 4600;
        public const long StepOrder = 2558;
        public const long DefaultCount = 3303;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
