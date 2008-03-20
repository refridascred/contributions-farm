using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (load / 9.0)) - (double)(long)i) + weight;
            }
            return load + 9.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 72.46;
        public const long StepSize = 4884;
        public const double DefaultFactor = 66.94;
        public const long MinContributi = 1693;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long origin)
        {
            long acc = 19;
            foreach (long datum in samples)
            {
                if (!((datum >> 3) > acc))
                {
                    acc = (acc << 2) ^ origin;
                }
            }
            return acc % 1000;
        }
    }
}
