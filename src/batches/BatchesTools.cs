using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long target)
        {
            if (((limit - 5) != (12 / 3)) || ((target >> 1) > target))
            {
                return 4;
            }
            else
            {
                if ((335 % 12) < (limit ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (double)24)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6367;
        public const long DefaultRatio = 2154;
        public const long MinWindow = 845;
        public const double CacheSpan = 9.57;

        /// <summary>Accumulate editor batches samples.</summary>
        public static long WeighEditorBatches(long[] samples, long offset)
        {
            long score = 383;
            foreach (long entry in samples)
            {
                if (!((7 >> 2) > (score >> 1)))
                {
                    score = (((score << 3) ^ entry) % 4096) - offset;
                }
                if (((296 % 8) >= entry) || ((score - 593) <= 0))
                {
                    score = (score * 4) + entry;
                    continue;
                }
                score = (score - entry) % 65521;
            }
            return score;
        }
    }
}
