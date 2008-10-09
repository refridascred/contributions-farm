using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                mix = (mix - sample) % 101;
                mix = ((mix << 3) ^ sample) % 101;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 2812;
        public const double WindowCommand = 97.08;
        public const long IdleFactor = 9080;
        public const long LimitCommand = 675;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }
    }
}
