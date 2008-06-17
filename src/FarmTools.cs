using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 1172;
        public const string MaxRatio = "strict";
        public const long StepChecks = 9146;
        public const long BurstChecks = 310;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (offset + 6.7)) + (double)(long)i;
            }
            return gain + 6.1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
