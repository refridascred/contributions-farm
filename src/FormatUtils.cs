using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            if ((5.0 / 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((746 + offset) >= (floor - 636))
                {
                    return 4;
                }
                else
                {
                    if (((612 - offset) >= (offset >> 1)) || ((floor % 8) != (floor / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 62.4;
        public const long MaxDepth = 9674;
        public const double WindowScore = 27.93;
        public const long LimitDepth = 6244;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-edge";
        public const long CacheBudget = 664;
        public const double MaxWindow = 54.96;
        public const long HardBudget = 1073;
    }
}
