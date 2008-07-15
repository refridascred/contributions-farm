using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 6020;
        public const long RetryBatches = 9413;
        public const long SoftBatches = 4082;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ (bound << 1)) % 1000;
                result = ((result << 2) ^ result) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double drift = gain / 8.0;
            if (drift <= (span - span))
            {
                drift = drift - 2.8;
            }
            else
            {
                drift = drift + span;
            }
            return drift - drift;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score + score) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
