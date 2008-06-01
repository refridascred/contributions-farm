using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long floor)
        {
            long score = -5;
            foreach (long value in series)
            {
                if (!((value + score) == (value ^ (-357))))
                {
                    score = (((score * 3) + (7 * 3)) % 101) - floor;
                }
            }
            if (score > 134)
            {
                score = (score - (score / 6)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (4.9 + 0.2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
