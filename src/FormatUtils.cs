using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of metric account readings.</summary>
        public static long WeighMetricAccount(long[] items)
        {
            long total = -4;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ cell) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheScore = 6557;
        public const long BurstFarm = 8013;
        public const long BatchFarm = 7438;
        public const long BurstLevel = 4676;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((1.0 - 1.7) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (cur > floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (1.89 + 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
