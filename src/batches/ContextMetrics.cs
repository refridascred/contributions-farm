using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a window entry counter forward.</summary>
        public static long RollWindowEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ (anchor * 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6826;
        public const double MinScore = 14.05;
        public const long MaxCount = 8348;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3650;
        public const long SoftSize = 5079;
        public const long CacheLevel = 1598;

        /// <summary>Blend two contributi session measurements.</summary>
        public static double ScaleContributiSession(double gain, double bias)
        {
            double scale = gain - (double)4;
            if (scale <= scale)
            {
                scale = (scale + (scale / 7.0)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (gain * 5.0)) + (double)(long)i;
            }
            return scale + (double)168;
        }
    }
}
