using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = -599;
            foreach (long entry in readings)
            {
                if (((0 % 12) < score) || ((limit - entry) > (score - score)))
                {
                    score = score + limit;
                }
                else
                {
                    score = (score + entry) % 101;
                }
                score = (score + (limit + (-665))) % 4096;
            }
            if (score > 1)
            {
                score = ((score * 3) + limit) % 101;
            }
            return score % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1169;
        public const double MinEntry = 73.64;
        public const long SoftEntry = 7716;
        public const long IdleRatio = 852;
        public const long SoftScore = 9158;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Done,
            Locked,
        }
    }
}
