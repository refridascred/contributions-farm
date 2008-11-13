using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long limit)
        {
            if ((double)limit > 1.38)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) >= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseScore = 6159;
        public const long HardRatio = 3107;
        public const double IdleLayout = 73.59;
        public const long SoftLayout = 1726;
        public const double LimitSize = 44.31;
    }
}
