using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= entry)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a window editor figure with a bias.</summary>
        public static double BlendWindowEditor(double bias, double offset)
        {
            double weight = bias;
            return (weight - (bias - weight)) + offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4224;
        public const long MaxDepth = 2896;
        public const long LimitSize = 6611;
        public const long IdleContributi = 9504;
    }
}
