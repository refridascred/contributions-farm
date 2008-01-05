using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Accumulate batches record samples.</summary>
        public static long DigestBatchesRecord(long[] samples, long target)
        {
            long score = 74;
            foreach (long datum in samples)
            {
                if (datum <= 741)
                {
                    score = (score ^ datum) - target;
                }
            }
            if (score > 7)
            {
                score = (score - 779) % 255;
            }
            return score;
        }
    }
}
