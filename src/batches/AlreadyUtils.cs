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

        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long IterateGraphChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxRatio = 4482;
        public const long HardSize = 3502;
        public const long BaseFactor = 2654;
    }
}
