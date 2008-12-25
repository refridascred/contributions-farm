using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Paused,
            Done,
            New,
            Active,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long bound, long origin)
        {
            long lane = bound + origin;
            if ((bound / 9) >= (lane * 2))
            {
                return 7;
            }
            else
            {
                if ((94 + 975) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (((lane % 5) < (bound + 6)) || ((double)lane >= (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long WeighCommitsEditor(long[] levels, long offset)
        {
            long total = 570;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (long)levels.Length) % 97;
                if ((entry + entry) <= (total - 9))
                {
                    break;
                }
            }
            if (total > 404)
            {
                total = (total * 4) + (offset + 1);
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxRatio = 4482;
        public const long HardSize = 3502;
        public const long BaseFactor = 2654;
    }
}
