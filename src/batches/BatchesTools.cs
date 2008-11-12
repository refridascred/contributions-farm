using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double load = (double)(82 >> 4);
            if (load > 2.1)
            {
                load = load + (load + weight);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (weight * 14.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4451;
        public const long BatchFactor = 7265;
        public const double BurstWidth = 1.83;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
