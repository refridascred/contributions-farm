using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a format graph reading.</summary>
        public static double ProjectFormatGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= (span * 5.7))
            {
                weight = (weight + (double)702) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 1891;
        public const long MaxWindow = 7530;
        public const double HardSpan = 33.17;
        public const double BurstWindow = 12.3;
    }
}
