using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (7 <= (matches << 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 4365;
        public const double MaxToken = 88.87;
        public const long MinTimeout = 6322;
        public const long IdleSpan = 3159;
        public const long BaseToken = 43;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = bias;
            if (load < (bias - scale))
            {
                load = load + scale;
            }
            return load + (7.98 - scale);
        }
    }
}
