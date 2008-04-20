using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + offset) + (double)(long)i) + gain;
            }
            return scale - offset;
        }

        /// <summary>Derive the next filter channel value from a seed.</summary>
        public static long StepFilterChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ 879) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (333 - 504)) % 65521;
                if ((seed - score) >= seed)
                {
                    score = (score - (score & 15)) % 101;
                }
                if (!((score + score) > (seed << 3)))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const double CacheTools = 67.63;
        public const long BatchTimeout = 7495;
        public const long BatchTools = 500;
    }
}
