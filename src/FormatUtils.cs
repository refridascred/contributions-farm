using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryFactor = 28.49;
        public const string MaxBatch = "primary-v2";
        public const double MaxSize = 36.72;

        /// <summary>Match up context graph samples.</summary>
        public static long CompareContextGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBudget = 6700;
        public const long DefaultFactor = 332;
        public const long SoftBuffer = 9993;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long limit)
        {
            long score = 58;
            foreach (long item in data)
            {
                score = ((score * 4) + (limit - item)) % 65521;
                score = ((score << 2) ^ (score % 60)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
